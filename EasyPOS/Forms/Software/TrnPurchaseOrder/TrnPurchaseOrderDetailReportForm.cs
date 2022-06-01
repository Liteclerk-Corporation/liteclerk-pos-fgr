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

namespace EasyPOS.Forms.Software.TrnPurchaseOrder
{
    public partial class TrnPurchaseOrderDetailReportForm : Form
    {
        Int32 _purchaseOrderId = 0;
        public TrnPurchaseOrderDetailReportForm(Int32 purchaseOrderId)
        {
            InitializeComponent();

            _purchaseOrderId = purchaseOrderId;
            PrintPurchaseOrderDetailReport();
        }

        public void PrintPurchaseOrderDetailReport()
        {
            try
            {
                Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

                iTextSharp.text.Font fontTimesNewRoman10 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10);
                iTextSharp.text.Font fontTimesNewRoman10Italic = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font fontTimesNewRoman11 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 11);
                iTextSharp.text.Font fontTimesNewRoman11Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 11, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontTimesNewRoman14Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5F, 100.0F, BaseColor.DARK_GRAY, Element.ALIGN_MIDDLE, 10F)));

                var fileName = "PurchaseOrderDetailReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                var currentUser = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;

                var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                Document document = new Document(PageSize.LETTER);
                document.SetMargins(30f, 30f, 150f, 30f);

                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                pdfWriter.PageEvent = new PurchaseOrderDetailReportHeaderFooter(_purchaseOrderId);

                document.Open();

                var purchaseOrderLines = from d in db.TrnPurchaseOrderLines
                                         where d.PurchaseOrderId == _purchaseOrderId
                                         select d;
                if (purchaseOrderLines.Any())
                {
                    PdfPTable tableItem = new PdfPTable(5);
                    tableItem.SetWidths(new float[] { 90f, 20f, 20f, 30f, 30f });
                    tableItem.WidthPercentage = 100;

                    Decimal totalAmount = 0;

                    foreach (var PurchaseOrderLines in purchaseOrderLines)
                    {
                        tableItem.AddCell(new PdfPCell(new Phrase(PurchaseOrderLines.MstItem.ItemDescription, fontTimesNewRoman11)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                        tableItem.AddCell(new PdfPCell(new Phrase(PurchaseOrderLines.Quantity.ToString("#,##0.00"), fontTimesNewRoman11)) { Border = 0, PaddingLeft = 3f, PaddingRight = 8f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableItem.AddCell(new PdfPCell(new Phrase(PurchaseOrderLines.MstItem.MstUnit.Unit, fontTimesNewRoman11)) { Border = 0, PaddingLeft = 8f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                        tableItem.AddCell(new PdfPCell(new Phrase(PurchaseOrderLines.Cost.ToString("#,##0.00"), fontTimesNewRoman11)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableItem.AddCell(new PdfPCell(new Phrase(PurchaseOrderLines.Amount.ToString("#,##0.00"), fontTimesNewRoman11)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });

                        totalAmount += PurchaseOrderLines.Amount;
                    }
                    tableItem.AddCell(new PdfPCell(new Phrase(line)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = -5f, Colspan = 5 });
                    tableItem.AddCell(new PdfPCell(new Phrase("Total: " + totalAmount.ToString("#,##0.00"), fontTimesNewRoman11Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, Colspan = 5, HorizontalAlignment = 2 });

                    document.Add(tableItem);

                    PdfPTable tableUsers = new PdfPTable(3);
                    tableUsers.SetWidths(new float[] { 100f, 100f, 100f });
                    tableUsers.WidthPercentage = 100;
                    tableUsers.AddCell(new PdfPCell(new Phrase("Prepared by", fontTimesNewRoman11Bold)) { PaddingTop = 5f, PaddingBottom = 9f, PaddingLeft = 5f, PaddingRight = 5f });
                    tableUsers.AddCell(new PdfPCell(new Phrase("Checked by", fontTimesNewRoman11Bold)) { PaddingTop = 5f, PaddingBottom = 9f, PaddingLeft = 5f, PaddingRight = 5f });
                    tableUsers.AddCell(new PdfPCell(new Phrase("Approved by", fontTimesNewRoman11Bold)) { PaddingTop = 5f, PaddingBottom = 9f, PaddingLeft = 5f, PaddingRight = 5f });
                    tableUsers.AddCell(new PdfPCell(new Phrase(" ")) { PaddingBottom = 30f });
                    tableUsers.AddCell(new PdfPCell(new Phrase(" ")) { PaddingBottom = 30f });
                    tableUsers.AddCell(new PdfPCell(new Phrase(" ")) { PaddingBottom = 30f });
                    tableUsers.AddCell(new PdfPCell(new Phrase(purchaseOrderLines.FirstOrDefault().TrnPurchaseOrder.MstUser.FullName, fontTimesNewRoman11)) { HorizontalAlignment = 1, PaddingTop = 5f, PaddingBottom = 9f, PaddingLeft = 5f, PaddingRight = 5f });
                    tableUsers.AddCell(new PdfPCell(new Phrase(purchaseOrderLines.FirstOrDefault().TrnPurchaseOrder.MstUser1.FullName, fontTimesNewRoman11)) { HorizontalAlignment = 1, PaddingTop = 5f, PaddingBottom = 9f, PaddingLeft = 5f, PaddingRight = 5f });
                    tableUsers.AddCell(new PdfPCell(new Phrase(purchaseOrderLines.FirstOrDefault().TrnPurchaseOrder.MstUser2.FullName, fontTimesNewRoman11)) { HorizontalAlignment = 1, PaddingTop = 5f, PaddingBottom = 9f, PaddingLeft = 5f, PaddingRight = 5f });
                    document.Add(tableUsers);

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

        class PurchaseOrderDetailReportHeaderFooter : PdfPageEventHelper
        {
            public Int32 _purchaseOrderId = 0;
            public Data.easyposdbDataContext db;

            public PurchaseOrderDetailReportHeaderFooter(Int32 purchaseOrderId)
            {
                _purchaseOrderId = purchaseOrderId;
                db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                iTextSharp.text.Font fontTimesNewRoman10 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10);
                iTextSharp.text.Font fontTimesNewRoman10Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontTimesNewRoman10Italic = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font fontTimesNewRoman11 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 11);
                iTextSharp.text.Font fontTimesNewRoman11Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 11, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontTimesNewRoman14Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0F, 100.0F, BaseColor.BLACK, Element.ALIGN_MIDDLE, 7F)));

                var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                var purchaseOrder = from d in db.TrnPurchaseOrders
                              where d.Id == _purchaseOrderId
                              select d;

                String companyName = systemCurrent.CompanyName;
                String address = systemCurrent.Address;
                String contactNo = systemCurrent.ContactNo;
                String documentTitle = "Purchase Order";

                String purchaseOrderNumber = purchaseOrder.FirstOrDefault().PurchaseOrderNumber;
                String purchaseOrderDate = purchaseOrder.FirstOrDefault().PurchaseOrderDate.ToShortDateString();
                String supplier = purchaseOrder.FirstOrDefault().MstSupplier.Supplier;
                String remarks = purchaseOrder.FirstOrDefault().Remarks;

                PdfPTable tableHeader = new PdfPTable(4);
                tableHeader.SetWidths(new float[] { 20f, 40f, 20f, 50f });
                tableHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;

                tableHeader.AddCell(new PdfPCell(new Phrase(companyName + "\n", fontTimesNewRoman14Bold)) { Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 0f });               
                tableHeader.AddCell(new PdfPCell(new Phrase(documentTitle + "\n", fontTimesNewRoman14Bold)) { HorizontalAlignment = 2, Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 0f });
                tableHeader.AddCell(new PdfPCell(new Phrase(address + "\n", fontTimesNewRoman11)) { Colspan = 4, Border = 0, Padding = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(contactNo + "\n", fontTimesNewRoman11)) { Colspan = 4, Border = PdfPCell.BOTTOM_BORDER, Padding = 3f, PaddingBottom = 3f });
                
                tableHeader.AddCell(new PdfPCell(new Phrase("PO No.: ", fontTimesNewRoman11Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(purchaseOrderNumber, fontTimesNewRoman11)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase("PO Date: ", fontTimesNewRoman11Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(purchaseOrderDate, fontTimesNewRoman11)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });
                
                tableHeader.AddCell(new PdfPCell(new Phrase("Supplier: ", fontTimesNewRoman11Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(supplier, fontTimesNewRoman11)) { Colspan = 4, Border = 0, HorizontalAlignment = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });

                tableHeader.AddCell(new PdfPCell(new Phrase("Remarks: ", fontTimesNewRoman11Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(remarks, fontTimesNewRoman11)) { Colspan = 3, Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 3f });

                PdfPTable tableItem = new PdfPTable(5);
                tableItem.SetWidths(new float[] { 90f, 20f, 20f, 30f, 30f });
                tableItem.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tableItem.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman11Bold)) { Border = 0, Colspan = 5, PaddingTop = -8f });
                tableItem.AddCell(new PdfPCell(new Phrase("Item Description", fontTimesNewRoman11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableItem.AddCell(new PdfPCell(new Phrase("Qty.", fontTimesNewRoman11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableItem.AddCell(new PdfPCell(new Phrase("Unit", fontTimesNewRoman11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableItem.AddCell(new PdfPCell(new Phrase("Cost", fontTimesNewRoman11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableItem.AddCell(new PdfPCell(new Phrase("Amount", fontTimesNewRoman11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });

                tableHeader.AddCell(new PdfPCell(tableItem) { Border = 0, Colspan = 4, PaddingBottom = -5f, PaddingLeft = 0f, PaddingRight = 0f });
                tableHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 140f, writer.DirectContent);
            }
        }

    }
}
    

