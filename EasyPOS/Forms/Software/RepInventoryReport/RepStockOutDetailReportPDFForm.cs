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

namespace EasyPOS.Forms.Software.RepInventoryReport
{
    public partial class RepStockOutDetailReportPDFForm : Form
    {
        public DateTime startDate;
        public DateTime endDate;
        public String filter;

        public RepStockOutDetailReportPDFForm(DateTime dateStart, DateTime dateEnd)
        {
            InitializeComponent();

            startDate = dateStart;
            endDate = dateEnd;
            
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

                var fileName = "Stock Out Detail" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                var currentUser = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;

                var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                Document document = new Document(PageSize.LETTER);
                document.SetMargins(30f, 30f, 100f, 30f);

                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                pdfWriter.PageEvent = new ConfigureHeaderFooter(startDate, endDate);

                document.Open();


                Controllers.RepInventoryReportController repInvetoryReportController = new Controllers.RepInventoryReportController();
                var inventoryReportList = repInvetoryReportController.StockOutDetailReport(startDate, endDate);

                if (inventoryReportList.Any())
                {
                    Decimal grandTotalAmount = 0;

                    PdfPTable tableLines = new PdfPTable(10);
                    tableLines.SetWidths(new float[] { 80f, 50f, 50f, 50f, 50f, 50f, 50f, 50f, 50f, 50f});
                    tableLines.WidthPercentage = 100;

                    var stockOuts = from d in inventoryReportList
                                   group d by new
                                   {
                                       d.stockOutId,
                                       d.StockOutDate,
                                       d.StockOutNumber,
                                       d.ManualStockOutNumber,
                                       d.Remarks
                                   }
                                        into g
                                   select new
                                   {
                                       g.Key.stockOutId,
                                       g.Key.StockOutDate,
                                       g.Key.StockOutNumber,
                                       g.Key.ManualStockOutNumber,
                                       g.Key.Remarks,
                                   };
                    foreach (var stockOut in stockOuts)
                    {
                        Decimal totalAmount = 0;
                        Decimal count = 0;

                        tableLines.AddCell(new PdfPCell(new Phrase(stockOut.StockOutDate, fontTimesNewRoman10Bold)) { Colspan = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                        tableLines.AddCell(new PdfPCell(new Phrase(stockOut.StockOutNumber, fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                        tableLines.AddCell(new PdfPCell(new Phrase(stockOut.ManualStockOutNumber, fontTimesNewRoman10Bold)) { Colspan = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                        tableLines.AddCell(new PdfPCell(new Phrase(stockOut.Remarks, fontTimesNewRoman10Bold)) { Colspan = 5, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 4f, HorizontalAlignment = 0 });

                        var stockOutItems = from d in inventoryReportList
                                           where d.stockOutId == stockOut.stockOutId
                                           select d;

                        foreach (var inventoryReport in stockOutItems)
                        {
                            tableLines.AddCell(new PdfPCell(new Phrase(inventoryReport.BarCode, fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(inventoryReport.Item, fontTimesNewRoman10)) {Colspan = 5,HorizontalAlignment = 0, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(inventoryReport.Unit, fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(inventoryReport.Quantity.ToString("#,##0.00"), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(inventoryReport.Cost.ToString("#,##0.00"), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                            tableLines.AddCell(new PdfPCell(new Phrase(inventoryReport.Amount.ToString("#,##0.00"), fontTimesNewRoman10)) { HorizontalAlignment = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });

                            totalAmount += Convert.ToDecimal(inventoryReport.Amount);
                            count += 1;
                        }
                        tableLines.AddCell(new PdfPCell(new Phrase(line)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = -5f, Colspan = 10 });
                        tableLines.AddCell(new PdfPCell(new Phrase("Count: ", fontTimesNewRoman10Bold)) { Colspan = 2, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(count.ToString(), fontTimesNewRoman10Bold)) {Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 0 });
                        tableLines.AddCell(new PdfPCell(new Phrase("Sub - Total: ", fontTimesNewRoman10Bold)) {Colspan = 6, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(totalAmount.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });

                        grandTotalAmount += totalAmount;
                    }
                    tableLines.AddCell(new PdfPCell(new Phrase(line)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = -5f, Colspan = 10 });
                    tableLines.AddCell(new PdfPCell(new Phrase("Grand Total: ", fontTimesNewRoman10Bold)) { Colspan = 9, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(grandTotalAmount.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    
                    document.Add(tableLines);
                    document.Close();

                    //ProcessStartInfo info = new ProcessStartInfo(fileName)
                    //{
                    //    Verb = "Print",
                    //    CreateNoWindow = true,
                    //    WindowStyle = ProcessWindowStyle.Hidden
                    //};

                    //Process printDwg = new Process
                    //{
                    //    StartInfo = info
                    //};

                    //printDwg.Start();
                    //printDwg.Close();


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
            public DateTime startDate;
            public DateTime endDate;
            public String filter;

            public Data.easyposdbDataContext db;

            public ConfigureHeaderFooter(DateTime dateStart, DateTime dateEnd)
            {
                startDate = dateStart;
                endDate = dateEnd;

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
                String documentTitle = "Stock Out Detail Report";

                PdfPTable tableHeader = new PdfPTable(4);
                tableHeader.SetWidths(new float[] { 20f, 30f, 20f, 50f });
                tableHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tableHeader.AddCell(new PdfPCell(new Phrase(companyName, fontTimesNewRoman14Bold)) { Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(documentTitle, fontTimesNewRoman14Bold)) { HorizontalAlignment = 2, Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase("From : " + startDate.ToShortDateString() + " To: " + endDate.ToShortDateString() + "\n", fontTimesNewRoman10)) { Colspan = 4, Border = 0, Padding = 3f, PaddingBottom = 6f });

                PdfPTable tableLines = new PdfPTable(10);
                tableLines.SetWidths(new float[] { 80f, 50f, 50f, 50f, 50f, 50f, 50f, 50f, 50f, 50f});
                tableLines.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tableLines.AddCell(new PdfPCell(new Phrase("Barcode", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Item", fontTimesNewRoman10Bold)) {Colspan = 5, HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Unit", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Quantity", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Cost", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Amount", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableHeader.AddCell(new PdfPCell(tableLines) { Border = 0, Colspan = 4, PaddingBottom = -5f, PaddingLeft = 0f, PaddingRight = 0f });
                tableHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 67f, writer.DirectContent);
            }
        }
    }
}


