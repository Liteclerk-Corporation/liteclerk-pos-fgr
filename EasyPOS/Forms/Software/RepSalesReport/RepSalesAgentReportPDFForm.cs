using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.RepSalesReport
{
    public partial class RepSalesAgentReportPDFForm : Form
    {
        public DateTime dateStart;
        public DateTime dateEnd;
        public Int32 filterSalesAgentId;

        public RepSalesAgentReportPDFForm(DateTime startDate, DateTime endDate, Int32 salesAgentId)
        {
            InitializeComponent();

            dateStart = startDate;
            dateEnd = endDate;
            filterSalesAgentId = salesAgentId;

            PrintReport();
        }

        public void PrintReport()
        {
            try
            {
                Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

                iTextSharp.text.Font fontTimesNewRoman10 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10);
                iTextSharp.text.Font fontTimesNewRoman10Italic = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font fontTimesNewRoman10Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontTimesNewRoman14Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5F, 100.0F, BaseColor.DARK_GRAY, Element.ALIGN_MIDDLE, 10F)));

                Encoding utf8 = Encoding.UTF8;
                var fileName = "SalesAgentReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                var currentUser = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;

                var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                Document document = new Document(PageSize.LEGAL.Rotate());
                document.SetMargins(15f, 15f, 100f, 30f);

                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                pdfWriter.PageEvent = new ConfigureHeaderFooter(dateStart, dateEnd, filterSalesAgentId);

                document.Open();

                Controllers.RepSalesReportController repSalesAgentReportController = new Controllers.RepSalesReportController();
                var salesAgentList = repSalesAgentReportController.SalesAgentReport(dateStart, dateEnd, filterSalesAgentId);

                if (salesAgentList.Any())
                {
                    var groupedByAgents = from d in salesAgentList
                                          group d by new
                                          {
                                              d.SalesAgent
                                          } into g
                                          select g;

                    PdfPTable tableLines = new PdfPTable(7);
                    tableLines.SetWidths(new float[] { 20f, 15f, 30f, 65f, 30f, 30f, 35f});
                    tableLines.WidthPercentage = 100;

                    Decimal totalAmount = 0;

                    foreach (var agent in groupedByAgents)
                    {
                        Decimal _totalAmount = 0;
                        var salesAgents = from d in salesAgentList
                                          where d.SalesAgent == agent.Key.SalesAgent
                                          select d;

                        tableLines.AddCell(new PdfPCell(new Phrase(agent.Key.SalesAgent, fontTimesNewRoman14Bold)) {Colspan = 7, HorizontalAlignment = 0, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });

                        foreach (var salesDetail in salesAgents)
                        {
                            tableLines.AddCell(new PdfPCell(new Phrase(salesDetail.EntryDateTime.ToString(), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(salesDetail.Quantity.ToString("#,##0.00"), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(salesDetail.BarCode, fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(salesDetail.ItemDescription, fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(salesDetail.Price.ToString("#,##0.00"), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(salesDetail.DiscountAmount.ToString("#,##0.00"), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(salesDetail.Amount.ToString("#,##0.00"), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });

                            _totalAmount += Convert.ToDecimal(salesDetail.Amount);
                        }
                        tableLines.AddCell(new PdfPCell(new Phrase(line)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = -5f, Colspan = 7 });

                        tableLines.AddCell(new PdfPCell(new Phrase("SUBTOTAL: ", fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, Colspan = 6, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(_totalAmount.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });

                        totalAmount += _totalAmount;

                    }
                    tableLines.AddCell(new PdfPCell(new Phrase(line)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = -5f, Colspan = 7 });

                    tableLines.AddCell(new PdfPCell(new Phrase("OVERALL TOTAL: ", fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, Colspan = 6, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(totalAmount.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    document.Add(tableLines);
                    document.Close();

                    Process.Start(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        class ConfigureHeaderFooter : PdfPageEventHelper
        {
            public DateTime dateStart;
            public DateTime dateEnd;
            public Int32 filterSalesAgentId;

            public Data.easyposdbDataContext db;

            public ConfigureHeaderFooter(DateTime startDate, DateTime endDate, Int32 salesAgentId)
            {
                dateStart = startDate;
                dateEnd = endDate;
                filterSalesAgentId = salesAgentId;

                db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                iTextSharp.text.Font fontTimesNewRoman10 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10);
                iTextSharp.text.Font fontTimesNewRoman10Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontTimesNewRoman14Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0F, 100.0F, BaseColor.BLACK, Element.ALIGN_MIDDLE, 7F)));

                var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                String companyName = systemCurrent.CompanyName;
                String documentTitle = "Sales Agent Report";

                PdfPTable tableHeader = new PdfPTable(4);
                tableHeader.SetWidths(new float[] { 20f, 30f, 20f, 50f });
                tableHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tableHeader.AddCell(new PdfPCell(new Phrase(companyName, fontTimesNewRoman14Bold)) { Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(documentTitle, fontTimesNewRoman14Bold)) { HorizontalAlignment = 2, Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase("From : " + dateStart.ToShortDateString() + " To: " + dateEnd.ToShortDateString() + "\n", fontTimesNewRoman10)) { Colspan = 4, Border = 0, Padding = 3f, PaddingBottom = 0 });


                PdfPTable tableLines = new PdfPTable(7);
                tableLines.SetWidths(new float[] { 20f, 15f, 30f, 65f, 30f, 30f, 35f });
                tableLines.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;

                tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 0 });
                tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 0 });
                tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 0 });
                tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 0 });
                tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 0 });
                tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 0 });
                tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 0 });

                tableLines.AddCell(new PdfPCell(new Phrase("Time", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Quantity", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Barcode", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Item", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Price", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Discount", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Amount", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });

                tableHeader.AddCell(new PdfPCell(tableLines) { Border = 0, Colspan = 4, PaddingBottom = -5f, PaddingLeft = 0f, PaddingRight = 0f });
                tableHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 67f, writer.DirectContent);
            }
        }
    }
}


