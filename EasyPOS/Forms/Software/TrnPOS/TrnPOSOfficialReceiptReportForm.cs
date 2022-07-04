using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSOfficialReceiptReportForm : Form
    {
        public Int32 trnSalesId = 0;
        public Int32 trnCollectionId = 0;
        public Boolean trnIsReprinted = false;

        public TrnPOSOfficialReceiptReportForm(Int32 salesId, Int32 collectionId, Boolean isReprinted, String printerName)
        {
            InitializeComponent();

            trnSalesId = salesId;
            trnCollectionId = collectionId;
            trnIsReprinted = isReprinted;

            if (trnIsReprinted == true)
            {
                printDocumentOfficialReceipt.PrinterSettings.PrinterName = printerName;
            }
            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                printDocumentOfficialReceipt.Print();

            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 280, 38500);
                printDocumentOfficialReceipt.Print();
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "HP A799")
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 280, 38500);
                printDocumentOfficialReceipt.Print();
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "ZiJiang Label Printer")
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 20000);
                printDocumentOfficialReceipt.Print();
            }
            else
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                printDocumentOfficialReceipt.Print();
            }
        }

        private void printDocumentOfficialReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // ============
            // Data Context
            // ============
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            // =============
            // Font Settings
            // =============
            Font fontArial12Bold = new Font("Arial", 12, FontStyle.Bold);
            Font fontArial12Regular = new Font("Arial", 12, FontStyle.Regular);
            Font fontArial11Bold = new Font("Arial", 11, FontStyle.Bold);
            Font fontArial11Regular = new Font("Arial", 11, FontStyle.Regular);
            Font fontArial8Bold = new Font("Arial", 8, FontStyle.Bold);
            Font fontArial8Regular = new Font("Arial", 8, FontStyle.Regular);
            Font fontArial7Bold = new Font("Arial", 7, FontStyle.Bold);
            Font fontArial7Regular = new Font("Arial", 7, FontStyle.Regular);


            // ==================
            // Alignment Settings
            // ==================
            StringFormat drawFormatCenter = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat drawFormatLeft = new StringFormat { Alignment = StringAlignment.Near };
            StringFormat drawFormatRight = new StringFormat { Alignment = StringAlignment.Far };

            float x, y;
            float width, height;
            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                x = 5; y = 5;
                width = 245.0F; height = 0F;
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                x = 5; y = 5;
                width = 270.0F; height = 0F;
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "HP A799")
            {
                x = 5; y = 5;
                width = 260.0F; height = 0F;
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "ZiJiang Label Printer")
            {
                x = 30; y = 5;
                width = 255.0F; height = 0F;
            }
            else
            {
                x = 5; y = 5;
                width = 170.0F; height = 0F;
            }

            // ==============
            // Tools Settings
            // ==============
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 1);
            Pen whitePen = new Pen(Color.White, 1);

            // ========
            // Graphics
            // ========
            Graphics graphics = e.Graphics;

            // ==============
            // System Current
            // ==============
            var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();
            var collections = from d in db.TrnCollections where d.Id == trnCollectionId select d;
            var sales = from d in db.TrnSales
                        where d.Id == trnSalesId
                        select d;

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "ZiJiang Label Printer")
            {
                // ============
                // Company Name
                // ============
                String companyName = systemCurrent.CompanyName;
                RectangleF companyNameRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(companyName, fontArial8Bold, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(companyName, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += companyNameRectangle.Size.Height + 1.0F;

                // ===============
                // Company Address
                // ===============
                String companyAddress = systemCurrent.Address;
                RectangleF companyAddressRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(companyAddress, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(companyAddress, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += companyAddressRectangle.Size.Height + 5F;

                // =======================
                // Company Contact Number
                // =======================
                String companyContactNumber = systemCurrent.ContactNo;
                RectangleF companyContactNumberRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(companyContactNumber, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(companyContactNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += companyContactNumberRectangle.Size.Height + 4F;

                // =======
                // Title
                // =======
                String title = "S A L E S  O R D E R";
                RectangleF titleRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(title, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(title, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += titleRectangle.Size.Height + 1F;

                String collectionNumberText = collections.FirstOrDefault().CollectionNumber;
                graphics.DrawString(collectionNumberText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionNumberText, fontArial8Regular).Height;

                String collectionDateText = collections.FirstOrDefault().CollectionDate.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionDateText, fontArial8Regular).Height;

                String collectionTimeText = collections.FirstOrDefault().UpdateDateTime.ToString("H:mm:ss", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionTimeText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionTimeText, fontArial8Regular).Height;

                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 10);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 10);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "58mm Printer") 
            {
                // ============
                // Company Name
                // ============
                String companyName = systemCurrent.CompanyName;
                RectangleF companyNameRectangle = new RectangleF

                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(companyName, fontArial8Bold, 170, StringFormat.GenericDefault).Height))
                };

                graphics.DrawString(companyName, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += companyNameRectangle.Size.Height + 1.0F;

                // ===============
                // Company Address
                // ===============
                String companyAddress = systemCurrent.Address;
                RectangleF companyAddressRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(companyAddress, fontArial8Regular, 170, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(companyAddress, fontArial8Regular, Brushes.Black, companyAddressRectangle, drawFormatCenter);
                y += companyAddressRectangle.Size.Height;

                // ==========
                // TIN Number
                // ==========
                String TINNumber = "TIN: " + systemCurrent.TIN;
                RectangleF TINNumbersRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(TINNumber, fontArial8Regular, 170, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(TINNumber, fontArial8Regular, Brushes.Black, TINNumbersRectangle, drawFormatCenter);
                y += TINNumbersRectangle.Size.Height;

                // =============
                // Serial Number
                // =============
                String serialNo = "SN: " + systemCurrent.SerialNo;
                RectangleF serialNoDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(serialNo, fontArial8Regular, 170, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(serialNo, fontArial8Regular, Brushes.Black, serialNoDataRectangle, drawFormatCenter);
                y += serialNoDataRectangle.Size.Height;

                //==============
                // Permit Number
                //==============
                String permitNumber = "PN: " + systemCurrent.PermitNo;
                RectangleF permitNoDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(permitNumber, fontArial8Regular, 170, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(permitNumber, fontArial8Regular, Brushes.Black, permitNoDataRectangle, drawFormatCenter);
                y += permitNoDataRectangle.Size.Height;

                //=====================
                // Accreditation Number
                //=====================
                String accrdNo = "ACRED No.: " + systemCurrent.AccreditationNo;
                RectangleF accrdNoDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(accrdNo, fontArial8Regular, 170, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(accrdNo, fontArial8Regular, Brushes.Black, accrdNoDataRectangle, drawFormatCenter);
                y += accrdNoDataRectangle.Size.Height;

                // ==============
                // Machine Number
                // ==============
                String machineNo = "MIN: " + systemCurrent.MachineNo;
                RectangleF MINNumbersRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(170, ((int)graphics.MeasureString(machineNo, fontArial8Regular, 170, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(machineNo, fontArial8Regular, Brushes.Black, MINNumbersRectangle, drawFormatCenter);
                y += MINNumbersRectangle.Size.Height;

                // ======================
                // Official Receipt Title
                // ======================
                String officialReceiptTitle = systemCurrent.ORPrintTitle;
                graphics.DrawString(officialReceiptTitle, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(officialReceiptTitle, fontArial8Regular).Height;

                // =================
                // Collection Header
                // =================
                if (collections.Any())
                {
                    String terminalText = "Terminal: " + collections.FirstOrDefault().MstTerminal.Terminal;
                    graphics.DrawString(terminalText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(terminalText, fontArial8Regular).Height;

                    String collectionNumberText = collections.FirstOrDefault().CollectionNumber;
                    graphics.DrawString(collectionNumberText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(collectionNumberText, fontArial8Regular).Height;

                    String collectionDateText = collections.FirstOrDefault().CollectionDate.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                    graphics.DrawString(collectionDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(collectionDateText, fontArial8Regular).Height;

                    String collectionTimeText = collections.FirstOrDefault().UpdateDateTime.ToString("H:mm:ss", CultureInfo.InvariantCulture);
                    graphics.DrawString(collectionTimeText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(collectionTimeText, fontArial8Regular).Height;

                    if (trnIsReprinted)
                    {
                        graphics.DrawString("REPRINTED", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                        y += graphics.MeasureString("REPRINTED", fontArial8Regular).Height;
                    }

                    if (sales.FirstOrDefault().TableId != null && sales.FirstOrDefault().MstTable.TableCode != "Walk-in")
                    {
                        String tableNo = "Table: " + sales.FirstOrDefault().MstTable.TableCode;
                        graphics.DrawString(tableNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                        y += graphics.MeasureString(tableNo, fontArial8Regular).Height;
                    }
                }

                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);
            }
            else
            {
                // ============
                // Company Name
                // ============
                String companyName = systemCurrent.CompanyName;
                RectangleF companyNameRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(companyName, fontArial8Bold, 245, StringFormat.GenericDefault).Height))
                };

                graphics.DrawString(companyName, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += companyNameRectangle.Size.Height + 1.0F;

                // ===============
                // Company Address
                // ===============
                String companyAddress = systemCurrent.Address;
                RectangleF companyAddressRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(companyAddress, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(companyAddress, fontArial8Regular, Brushes.Black, companyAddressRectangle, drawFormatCenter);
                y += companyAddressRectangle.Size.Height;

                // ==========
                // TIN Number
                // ==========
                String TINNumber = "TIN: " + systemCurrent.TIN;
                RectangleF TINNumbersRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(TINNumber, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(TINNumber, fontArial8Regular, Brushes.Black, TINNumbersRectangle, drawFormatCenter);
                y += TINNumbersRectangle.Size.Height;

                // =============
                // Serial Number
                // =============
                String serialNo = "SN: " + systemCurrent.SerialNo;
                RectangleF serialNoDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(serialNo, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(serialNo, fontArial8Regular, Brushes.Black, serialNoDataRectangle, drawFormatCenter);
                y += serialNoDataRectangle.Size.Height;

                //==============
                // Permit Number
                //==============
                String permitNumber = "PN: " + systemCurrent.PermitNo;
                RectangleF permitNoDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(permitNumber, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(permitNumber, fontArial8Regular, Brushes.Black, permitNoDataRectangle, drawFormatCenter);
                y += permitNoDataRectangle.Size.Height;

                //=====================
                // Accreditation Number
                //=====================
                String accrdNo = "ACRED No.: " + systemCurrent.AccreditationNo;
                RectangleF accrdNoDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(accrdNo, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(accrdNo, fontArial8Regular, Brushes.Black, accrdNoDataRectangle, drawFormatCenter);
                y += accrdNoDataRectangle.Size.Height;

                // ==============
                // Machine Number
                // ==============
                String machineNo = "MIN: " + systemCurrent.MachineNo;
                RectangleF MINNumbersRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(245, ((int)graphics.MeasureString(machineNo, fontArial8Regular, 245, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(machineNo, fontArial8Regular, Brushes.Black, MINNumbersRectangle, drawFormatCenter);
                y += MINNumbersRectangle.Size.Height;

                // ======================
                // Official Receipt Title
                // ======================
                String officialReceiptTitle = systemCurrent.ORPrintTitle;
                graphics.DrawString(officialReceiptTitle, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(officialReceiptTitle, fontArial8Regular).Height;

                // =================
                // Collection Header
                // =================
                if (collections.Any())
                {
                    String terminalText = "Terminal: " + collections.FirstOrDefault().MstTerminal.Terminal;
                    graphics.DrawString(terminalText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(terminalText, fontArial8Regular).Height;

                    String collectionNumberText = collections.FirstOrDefault().CollectionNumber;
                    graphics.DrawString(collectionNumberText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(collectionNumberText, fontArial8Regular).Height;

                    String collectionDateText = collections.FirstOrDefault().CollectionDate.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                    graphics.DrawString(collectionDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(collectionDateText, fontArial8Regular).Height;

                    String collectionTimeText = collections.FirstOrDefault().UpdateDateTime.ToString("H:mm:ss", CultureInfo.InvariantCulture);
                    graphics.DrawString(collectionTimeText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(collectionTimeText, fontArial8Regular).Height;

                    if (trnIsReprinted)
                    {
                        graphics.DrawString("REPRINTED", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                        y += graphics.MeasureString("REPRINTED", fontArial8Regular).Height;

                        String rePrintedDate = DateTime.Now.ToShortDateString();
                        String rePrintedTime = DateTime.Now.ToShortTimeString();
                        graphics.DrawString(rePrintedDate + " " + rePrintedTime, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                        y += graphics.MeasureString(rePrintedDate, fontArial8Regular).Height;
                    }

                    if (sales.FirstOrDefault().TableId != null && sales.FirstOrDefault().MstTable.TableCode != "Walk-in")
                    {
                        String tableNo = "Table: " + sales.FirstOrDefault().MstTable.TableCode;
                        graphics.DrawString(tableNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                        y += graphics.MeasureString(tableNo, fontArial8Regular).Height;
                    }
                }

                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);
            }

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "58mm Printer")
            {
                // ==========
                // Sales Line
                // ==========
                Decimal totalGrossSales = 0;
                Decimal totalSales = 0;
                Decimal totalDiscount = 0;
                Decimal change = 0;
                Decimal totalVATSales = 0;
                Decimal totalVATAmount = 0;
                Decimal totalNonVATSales = 0;
                //Decimal totalVATExclusive = 0;
                Decimal totalVATExempt = 0;
                Decimal totalVATZeroRated = 0;
                Decimal totalNumberOfItems = 0;
                Decimal grossSales = 0;
                Decimal lessVAT = 0;

                String itemLabel = "\nITEM";
                String amountLabel = "\nAMOUNT";
                graphics.DrawString(itemLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(amountLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(itemLabel, fontArial7Regular).Height + 5.0F;

                Decimal totalServiceCharge = 0;
                Boolean hasServiceCharge = false;
                String itemPreparation;

                var salesLines = from d in db.TrnSalesLines where d.SalesId == trnSalesId select d;
                if (salesLines.Any())
                {
                    var salesLineGroupbyItem = from s in salesLines
                                               group s by new
                                               {
                                                   s.SalesId,
                                                   s.ItemId,
                                                   s.MstItem,
                                                   s.UnitId,
                                                   s.MstUnit,
                                                   s.NetPrice,
                                                   s.Price,
                                                   s.TaxId,
                                                   s.MstTax,
                                                   s.DiscountId,
                                                   s.DiscountRate,
                                                   s.SalesAccountId,
                                                   s.AssetAccountId,
                                                   s.CostAccountId,
                                                   s.TaxAccountId,
                                                   s.SalesLineTimeStamp,
                                                   s.UserId,
                                                   s.Preparation,
                                                   s.Price1,
                                                   s.Price2,
                                                   s.Price2LessTax,
                                                   s.PriceSplitPercentage
                                               } into g
                                               select new
                                               {
                                                   g.Key.ItemId,
                                                   g.Key.MstItem,
                                                   g.Key.MstItem.ItemDescription,
                                                   g.Key.MstUnit.Unit,
                                                   g.Key.Price,
                                                   g.Key.NetPrice,
                                                   g.Key.DiscountId,
                                                   g.Key.DiscountRate,
                                                   g.Key.Preparation,
                                                   g.Key.TaxId,
                                                   g.Key.MstTax,
                                                   g.Key.MstTax.Tax,
                                                   Amount = g.Sum(a => a.Amount),
                                                   Quantity = g.Sum(a => a.Quantity),
                                                   DiscountAmount = g.Sum(a => a.DiscountAmount * a.Quantity),
                                                   TaxAmount = g.Sum(a => a.TaxAmount)
                                               };

                    if (salesLineGroupbyItem.Any())
                    {
                        foreach (var salesLine in salesLineGroupbyItem.ToList())
                        {
                            if (salesLine.MstItem.ItemCode != "0000000001")
                            {
                                totalNumberOfItems += 1;
                            }
                            else
                            {
                                totalNumberOfItems += 0;
                            }

                            totalGrossSales += salesLine.Amount + salesLine.DiscountAmount;
                            totalSales += salesLine.Amount;
                            totalDiscount += salesLine.DiscountAmount;
                            grossSales += salesLine.Quantity * salesLine.Price;

                            if (salesLine.MstTax.Code == "VAT")
                            {
                                totalVATSales += (salesLine.Price * salesLine.Quantity) - ((salesLine.Price * salesLine.Quantity) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));
                                totalVATAmount += salesLine.TaxAmount;
                            }
                            else if (salesLine.MstTax.Code == "NONVAT")
                            {
                                totalNonVATSales += salesLine.Price * salesLine.Quantity;
                            }
                            else if (salesLine.MstTax.Code == "EXEMPTVAT")
                            {
                                totalVATExempt += salesLine.Amount;

                                //if (salesLine.MstItem.MstTax1.Rate > 0)
                                //{
                                //    totalVATExempt += (salesLine.Price * salesLine.Quantity) - ((salesLine.Price * salesLine.Quantity) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));
                                //}
                                //else
                                //{
                                //    totalVATExempt += salesLine.Price * salesLine.Quantity;
                                //}
                            }
                            else if (salesLine.MstTax.Code == "ZEROVAT")
                            {
                                totalVATZeroRated += salesLine.Amount;
                            }

                            lessVAT = (grossSales / Convert.ToDecimal(1.12)) * Convert.ToDecimal(0.12);

                            if (salesLine.MstItem.BarCode != "0000000001")
                            {
                                Decimal _amount = salesLine.Price * salesLine.Quantity;
                                Decimal _VAT = _amount;

                                if (salesLine.MstTax.Code == "EXEMPTVAT")
                                {
                                    _VAT = _amount / (1 + (salesLine.MstItem.MstTax1.Rate / 100));
                                }

                                if (salesLine.Preparation == "NA")
                                {
                                    itemPreparation = "";
                                }
                                else
                                {
                                    itemPreparation = salesLine.Preparation;
                                }

                                String itemData;
                                if (Modules.SysCurrentModule.GetCurrentSettings().ShowPriceDescriptioninReceipts == true)
                                {
                                    var itemPrices = from d in db.MstItemPrices
                                                     where d.ItemId == salesLine.ItemId
                                                     && d.Price == salesLine.Price
                                                     select d;
                                    if (itemPrices.Any())
                                    {
                                        var itemPrice = itemPrices.FirstOrDefault().PriceDescription;
                                        itemData = salesLine.ItemDescription + " " + itemPreparation + " - " + itemPrice + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                    }
                                    else
                                    {
                                        itemData = salesLine.ItemDescription + " " + itemPreparation + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];

                                    }
                                }
                                else
                                {
                                    itemData = salesLine.ItemDescription + " " + itemPreparation + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                }
                                String itemAmountData = (_VAT).ToString("#,##0.00");
                                RectangleF itemDataRectangle = new RectangleF
                                {
                                    X = x,
                                    Y = y,
                                    Size = new Size(200, ((int)graphics.MeasureString(itemData, fontArial7Regular, 200, StringFormat.GenericDefault).Height))
                                };
                                graphics.DrawString(itemData, fontArial7Regular, Brushes.Black, itemDataRectangle, drawFormatLeft);
                                graphics.DrawString(itemAmountData, fontArial7Regular, drawBrush, new RectangleF(x, y, 170.0F, height), drawFormatRight);

                                y += itemDataRectangle.Size.Height + 3.0F;
                            }
                            else
                            {
                                hasServiceCharge = true;
                                totalServiceCharge += salesLine.Amount;
                            }
                        }
                    }
                }

                // ========
                // 2nd Line
                // ========
                Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 10);
                Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 10);
                graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

                // ==============================
                // Total Sales and Total Discount
                // ==============================
                if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                {
                    String grossSalesLabel = "\nGross Sales";
                    String grossSalesAmount = "\n" + (grossSales.ToString("#,##0.00"));
                    graphics.DrawString(grossSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(grossSalesAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(grossSalesAmount, fontArial7Regular).Height;

                    String lessVATLabel = "Less VAT";
                    String lessVATAmount = lessVAT.ToString("#,##0.00");
                    graphics.DrawString(lessVATLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(lessVATAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(lessVATAmount, fontArial7Regular).Height;

                    String totalSalesLabel = "Total Sales";
                    String totalSalesAmount = (totalGrossSales - totalServiceCharge).ToString("#,##0.00");
                    graphics.DrawString(totalSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalSalesAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalSalesAmount, fontArial7Regular).Height;
                }
                else
                {
                    String totalSalesLabel = "\nTotal Sales";
                    String totalSalesAmount = "\n" + (totalGrossSales - totalServiceCharge).ToString("#,##0.00");
                    graphics.DrawString(totalSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalSalesAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalSalesAmount, fontArial7Regular).Height;
                }

                if (hasServiceCharge == true)
                {
                    String totalServiceChangeLabel = "Service Charge";
                    String totalServiceChangeAmount = totalServiceCharge.ToString("#,##0.00");
                    graphics.DrawString(totalServiceChangeLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalServiceChangeAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalServiceChangeAmount, fontArial7Regular).Height;
                }

                String totalDiscountLabel = "Total Discount";
                String totalDiscountAmount = totalDiscount.ToString("#,##0.00");
                graphics.DrawString(totalDiscountLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalDiscountAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalDiscountAmount, fontArial7Regular).Height;

                String netSalesLabel = "Net Sales";
                String netSalesAmount = totalSales.ToString("#,##0.00");
                graphics.DrawString(netSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(netSalesAmount, fontArial11Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(netSalesAmount, fontArial11Regular).Height;

                String totalNumberOfItemsLabel = "Total No. of Item(s)\n\n";
                String totalNumberOfItemsQuantity = totalNumberOfItems.ToString("#,##0.00") + "\n\n";
                graphics.DrawString(totalNumberOfItemsLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalNumberOfItemsQuantity, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalNumberOfItemsQuantity, fontArial7Regular).Height;

                // ========
                // 3rd Line
                // ========
                Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) - 7);
                Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) - 7);
                graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);

                // ================
                // Collection Lines
                // ================
                var collectionLines = from d in db.TrnCollectionLines where d.CollectionId == collections.FirstOrDefault().Id select d;
                if (collectionLines.Any())
                {
                    foreach (var collectionLine in collectionLines)
                    {
                        String collectionLineLabel = collectionLine.MstPayType.PayType;
                        String collectionLineAmount = collectionLine.Amount.ToString("#,##0.00");

                        graphics.DrawString(collectionLineLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(collectionLineAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(collectionLineAmount, fontArial7Regular).Height;
                    }
                }

                // ======
                // Change
                // ======
                change = collections.FirstOrDefault().ChangeAmount;

                String changelabel = "Change";
                String changeAmount = change.ToString("#,##0.00");
                graphics.DrawString(changelabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(changeAmount, fontArial11Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(changeAmount, fontArial7Regular).Height;

                // ========
                // 4th Line
                // ========
                Point forthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point forthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, forthLineFirstPoint, forthLineSecondPoint);

                // ============
                // VAT Analysis
                // ============
                String vatAnalysisLabel = "\nVAT ANALYSIS";
                graphics.DrawString(vatAnalysisLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                y += graphics.MeasureString(vatAnalysisLabel, fontArial7Regular).Height + +5.0F;

                String vatSalesLabel = "VAT Sales";
                String totalVatSalesAmount = totalVATSales.ToString("#,##0.00");
                graphics.DrawString(vatSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalVatSalesAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalVatSalesAmount, fontArial7Regular).Height;

                String totalVATAmountLabel = "VAT Amount";
                String totalVatAmount = totalVATAmount.ToString("#,##0.00");
                graphics.DrawString(totalVATAmountLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalVatAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalVatAmount, fontArial7Regular).Height;

                String totalNonVATSalesLabel = "Non-VAT";
                String totalNonVatAmount = totalNonVATSales.ToString("#,##0.00");
                graphics.DrawString(totalNonVATSalesLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalNonVatAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalNonVatAmount, fontArial7Regular).Height;

                //String totalVATExclusiveLabel = "VAT Exclusive";
                //String totaltotalVATExclusiveAmount = totalVATExclusive.ToString("#,##0.00");
                //graphics.DrawString(totalVATExclusiveLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                //graphics.DrawString(totaltotalVATExclusiveAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                //y += graphics.MeasureString(totaltotalVATExclusiveAmount, fontArial8Regular).Height;

                String totalVATExemptLabel = "VAT Exempt";
                String totaltotalVATExemptAmount = totalVATExempt.ToString("#,##0.00");
                graphics.DrawString(totalVATExemptLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totaltotalVATExemptAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totaltotalVATExemptAmount, fontArial7Regular).Height;

                String totalVATZeroRatedLabel = "VAT Zero Rated";
                String totalVatZeroRatedAmount = totalVATZeroRated.ToString("#,##0.00");
                graphics.DrawString(totalVATZeroRatedLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalVatZeroRatedAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalVatZeroRatedAmount, fontArial7Regular).Height;

                // ========
                // 6th Line
                // ========
                Point sixthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point sixthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, sixthLineFirstPoint, sixthLineSecondPoint);

                // ================
                // Cashier & Server
                // ================
                String cashier = collections.FirstOrDefault().MstUser3.UserName;
                String server = sales.FirstOrDefault().MstUser5.UserName;

                String cashierLabel = "\nCashier";
                String cashierUserData = "\n" + cashier;
                String serverLabel = "Teller";
                String serverUserData = server;
                graphics.DrawString(cashierLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(cashierUserData, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(cashierUserData, fontArial7Regular).Height;
                graphics.DrawString(serverLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(serverUserData, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(serverUserData, fontArial7Regular).Height;

                // ========
                // 7th Line
                // ========
                Point seventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point seventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, seventhLineFirstPoint, seventhLineSecondPoint);

                if (Modules.SysCurrentModule.GetCurrentSettings().ShowCustomerInfo == false)
                {
                    String soldToLabel = "\nCustomer Name: ___________";

                    // ==================================
                    // Senior Citizen and PWD Information
                    // ==================================
                    if (collections.FirstOrDefault().SalesId != null)
                    {
                        if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                        {
                            String seniorCitizenID = collections.FirstOrDefault().TrnSale.SeniorCitizenId;
                            String seniorCitizenName = collections.FirstOrDefault().TrnSale.SeniorCitizenName;
                            String seniorCitizenAge = collections.FirstOrDefault().TrnSale.SeniorCitizenAge.ToString();

                            graphics.DrawString("\nSC/PWD ID: " + seniorCitizenID, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenID, fontArial7Regular).Height;

                            graphics.DrawString("\nSC/PWD Name: " + seniorCitizenName, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenName, fontArial7Regular).Height;

                            graphics.DrawString("\nSC/PWD Age: " + seniorCitizenAge, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenAge, fontArial7Regular).Height;

                            // ========
                            // 8th Line
                            // ========
                            Point eightLineFirstPoint = new Point(0, Convert.ToInt32(y) + 18);
                            Point eightLineSecondPoint = new Point(500, Convert.ToInt32(y) + 18);
                            graphics.DrawLine(blackPen, eightLineFirstPoint, eightLineSecondPoint);

                            soldToLabel = "\n\nCustomer Name: ________";
                        }
                    }

                    graphics.DrawString(soldToLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToLabel, fontArial7Regular).Height;

                    String soldToAddressLabel = "Address: ______________";
                    graphics.DrawString(soldToAddressLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToAddressLabel, fontArial7Regular).Height;

                    String soldToTINLabel = "TIN: ____________";
                    graphics.DrawString(soldToTINLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial7Regular).Height;

                    String soldToBusinessStyleLabel = "Business Style: _____________";
                    graphics.DrawString(soldToBusinessStyleLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial7Regular).Height;
                }
                else
                {
                    String customerName = collections.FirstOrDefault().TrnSale.MstCustomer.Customer;
                    String customerAddress = collections.FirstOrDefault().TrnSale.MstCustomer.Address;
                    String customerTIN = collections.FirstOrDefault().TrnSale.MstCustomer.TIN;
                    String customerBusinessStyle = collections.FirstOrDefault().TrnSale.MstCustomer.BusinessStyle;
                    String soldToLabel = "\nCustomer Name: " + customerName;
                    graphics.DrawString(soldToLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToLabel, fontArial7Regular).Height;

                    // ==================================
                    // Senior Citizen and PWD Information
                    // ==================================
                    if (collections.FirstOrDefault().SalesId != null)
                    {
                        if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                        {
                            String seniorCitizenID = collections.FirstOrDefault().TrnSale.SeniorCitizenId;
                            String seniorCitizenName = collections.FirstOrDefault().TrnSale.SeniorCitizenName;
                            String seniorCitizenAge = collections.FirstOrDefault().TrnSale.SeniorCitizenAge.ToString();

                            graphics.DrawString("\nSC/PWD ID: " + seniorCitizenID, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenID, fontArial7Regular).Height;

                            graphics.DrawString("\nSC/PWD Name: " + seniorCitizenName, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenName, fontArial7Regular).Height;

                            graphics.DrawString("\nSC/PWD Age: " + seniorCitizenAge, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenAge, fontArial7Regular).Height;

                            // ========
                            // 8th Line
                            // ========
                            Point eightLineFirstPoint = new Point(0, Convert.ToInt32(y) + 18);
                            Point eightLineSecondPoint = new Point(500, Convert.ToInt32(y) + 18);
                            graphics.DrawLine(blackPen, eightLineFirstPoint, eightLineSecondPoint);

                            soldToLabel = "\n\nCustomer Name: " + customerName;
                        }
                    }



                    String soldToAddressLabel = "Address: " + customerAddress;
                    graphics.DrawString(soldToAddressLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToAddressLabel, fontArial7Regular).Height;

                    String soldToTINLabel = "TIN: " + customerTIN;
                    graphics.DrawString(soldToTINLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial7Regular).Height;

                    String soldToBusinessStyleLabel = "Business Style: " + customerBusinessStyle;
                    graphics.DrawString(soldToBusinessStyleLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial7Regular).Height;
                }

                // ========
                // 9th Line
                // ========
                Point ninethLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point ninethLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, ninethLineFirstPoint, ninethLineSecondPoint);

                String remarks = "\nRemarks: " + sales.FirstOrDefault().Remarks;
                RectangleF remarksDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(150, ((int)graphics.MeasureString(remarks, fontArial7Regular, 150, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(remarks, fontArial7Regular, Brushes.Black, remarksDataRectangle, drawFormatLeft);
                y += remarksDataRectangle.Size.Height;

                //// =========
                //// 10th Line
                //// =========
                //Point tenthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                //Point tenthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                //graphics.DrawLine(blackPen, tenthLineFirstPoint, tenthLineSecondPoint);

                //String orderNumber = "\nOrder Number: \n\n " + collections.FirstOrDefault().TrnSale.SalesNumber;
                //graphics.DrawString(orderNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                //y += graphics.MeasureString(orderNumber, fontArial8Regular).Height;

                // =========
                // 11th Line
                // =========
                Point eleventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point eleventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, eleventhLineFirstPoint, eleventhLineSecondPoint);

                String receiptFooter = "\n" + systemCurrent.ReceiptFooter;
                graphics.DrawString(receiptFooter, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(receiptFooter, fontArial7Regular).Height;
            }
            else
            {
                // ==========
                // Sales Line
                // ==========
                Decimal totalGrossSales = 0;
                Decimal totalSales = 0;
                Decimal totalDiscount = 0;
                Decimal change = 0;
                Decimal totalVATSales = 0;
                Decimal totalVATAmount = 0;
                Decimal totalNonVATSales = 0;
                //Decimal totalVATExclusive = 0;
                Decimal totalVATExempt = 0;
                Decimal totalVATZeroRated = 0;
                Decimal totalNumberOfItems = 0;
                Decimal grossSales = 0;
                Decimal lessVAT = 0;

                String itemLabel = "\nITEM";
                String amountLabel = "\nAMOUNT";
                graphics.DrawString(itemLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(amountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(itemLabel, fontArial8Regular).Height + 5.0F;

                Decimal totalServiceCharge = 0;
                Boolean hasServiceCharge = false;
                String itemPreparation;

                var salesLines = from d in db.TrnSalesLines where d.SalesId == trnSalesId select d;
                if (salesLines.Any())
                {
                    var salesLineGroupbyItem = from s in salesLines
                                               group s by new
                                               {
                                                   s.SalesId,
                                                   s.ItemId,
                                                   s.MstItem,
                                                   s.UnitId,
                                                   s.MstUnit,
                                                   s.NetPrice,
                                                   s.Price,
                                                   s.TaxId,
                                                   s.MstTax,
                                                   s.DiscountId,
                                                   s.DiscountRate,
                                                   s.SalesAccountId,
                                                   s.AssetAccountId,
                                                   s.CostAccountId,
                                                   s.TaxAccountId,
                                                   s.SalesLineTimeStamp,
                                                   s.UserId,
                                                   s.Preparation,
                                                   s.Price1,
                                                   s.Price2,
                                                   s.Price2LessTax,
                                                   s.PriceSplitPercentage
                                               } into g
                                               select new
                                               {
                                                   g.Key.ItemId,
                                                   g.Key.MstItem,
                                                   g.Key.MstItem.ItemDescription,
                                                   g.Key.MstUnit.Unit,
                                                   g.Key.Price,
                                                   g.Key.NetPrice,
                                                   g.Key.DiscountId,
                                                   g.Key.DiscountRate,
                                                   g.Key.Preparation,
                                                   g.Key.TaxId,
                                                   g.Key.MstTax,
                                                   g.Key.MstTax.Tax,
                                                   Amount = g.Sum(a => a.Amount),
                                                   Quantity = g.Sum(a => a.Quantity),
                                                   DiscountAmount = g.Sum(a => a.DiscountAmount * a.Quantity),
                                                   TaxAmount = g.Sum(a => a.TaxAmount)
                                               };

                    if (salesLineGroupbyItem.Any())
                    {
                        foreach (var salesLine in salesLineGroupbyItem.ToList())
                        {
                            if (salesLine.MstItem.ItemCode != "0000000001")
                            {
                                totalNumberOfItems += 1;
                            }
                            else
                            {
                                totalNumberOfItems += 0;
                            }

                            totalGrossSales += salesLine.Amount + salesLine.DiscountAmount;
                            totalSales += salesLine.Amount;
                            totalDiscount += salesLine.DiscountAmount;
                            grossSales += salesLine.Quantity * salesLine.Price;
                            

                            if (salesLine.MstTax.Code == "VAT")
                            {
                                totalVATSales += (salesLine.Price * salesLine.Quantity) - ((salesLine.Price * salesLine.Quantity) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));
                                totalVATAmount += salesLine.TaxAmount;
                            }
                            else if (salesLine.MstTax.Code == "NONVAT")
                            {
                                totalNonVATSales += salesLine.Price * salesLine.Quantity;
                            }
                            else if (salesLine.MstTax.Code == "EXEMPTVAT")
                            {
                                totalVATExempt += salesLine.Amount;

                                //if (salesLine.MstItem.MstTax1.Rate > 0)
                                //{
                                //    totalVATExempt += (salesLine.Price * salesLine.Quantity) - ((salesLine.Price * salesLine.Quantity) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));
                                //}
                                //else
                                //{
                                //    totalVATExempt += salesLine.Price * salesLine.Quantity;
                                //}
                            }
                            else if (salesLine.MstTax.Code == "ZEROVAT")
                            {
                                totalVATZeroRated += salesLine.Amount;
                            }

                            lessVAT = (grossSales / Convert.ToDecimal(1.12)) * Convert.ToDecimal(0.12);

                            if (salesLine.MstItem.BarCode != "0000000001")
                            {
                                Decimal _amount = salesLine.Price * salesLine.Quantity;
                                Decimal _VAT = _amount;

                                if (salesLine.MstTax.Code == "EXEMPTVAT")
                                {
                                    _VAT = _amount / (1 + (salesLine.MstItem.MstTax1.Rate / 100));
                                }

                                if (salesLine.Preparation == "NA")
                                {
                                    itemPreparation = "";
                                }
                                else
                                {
                                    itemPreparation = salesLine.Preparation;
                                }
                                String itemData;
                                if (Modules.SysCurrentModule.GetCurrentSettings().ShowPriceDescriptioninReceipts == true)
                                {
                                    var itemPrices = from d in db.MstItemPrices
                                                     where d.ItemId == salesLine.ItemId
                                                     && d.Price == salesLine.Price
                                                     select d;
                                    if (itemPrices.Any())
                                    {
                                        var itemPrice = itemPrices.FirstOrDefault().PriceDescription;
                                        itemData = salesLine.ItemDescription + " " + itemPreparation + " - " + itemPrice + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                    }
                                    else
                                    {
                                        itemData = salesLine.ItemDescription + " " + itemPreparation +"\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                    }
                                }
                                else if (Modules.SysCurrentModule.GetCurrentSettings().ItemQtyRemoveDecimalPlaces == true)
                                {
                                    itemData = salesLine.ItemDescription + " " + itemPreparation + "\n" + salesLine.Quantity.ToString("#,##0") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                }
                                else
                                {
                                    itemData = salesLine.ItemDescription + " " + itemPreparation + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00") + " - " + salesLine.MstTax.Code[0];
                                }
                                
                                String itemAmountData = (_VAT).ToString("#,##0.00");
                                RectangleF itemDataRectangle = new RectangleF
                                {
                                    X = x,
                                    Y = y,
                                    Size = new Size(200, ((int)graphics.MeasureString(itemData, fontArial8Regular, 200, StringFormat.GenericDefault).Height))
                                };
                                graphics.DrawString(itemData, fontArial8Regular, Brushes.Black, itemDataRectangle, drawFormatLeft);
                                if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
                                {
                                    graphics.DrawString(itemAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, 245.0F, height), drawFormatRight);
                                }
                                else
                                {
                                    graphics.DrawString(itemAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, 270, height), drawFormatRight);

                                }
                                y += itemDataRectangle.Size.Height + 3.0F;
                            }
                            else
                            {
                                hasServiceCharge = true;
                                totalServiceCharge += salesLine.Amount;
                            }
                        }
                    }
                }

                // ========
                // 2nd Line
                // ========
                Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 10);
                Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 10);
                graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

                // ==============================
                // Total Sales and Total Discount
                // ==============================
                if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                {
                    String grossSalesLabel = "\nGross Sales";
                    String grossSalesAmount = "\n" + (grossSales.ToString("#,##0.00"));
                    graphics.DrawString(grossSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(grossSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(grossSalesAmount, fontArial8Regular).Height;

                    String lessVATLabel = "Less VAT";
                    String lessVATAmount = lessVAT.ToString("#,##0.00");
                    graphics.DrawString(lessVATLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(lessVATAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(lessVATAmount, fontArial8Regular).Height;

                    String totalSalesLabel = "Total Sales";
                    String totalSalesAmount = (totalGrossSales - totalServiceCharge).ToString("#,##0.00");
                    graphics.DrawString(totalSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalSalesAmount, fontArial8Regular).Height;
                }
                else
                {
                    String totalSalesLabel = "\nTotal Sales";
                    String totalSalesAmount = "\n" + (totalGrossSales - totalServiceCharge).ToString("#,##0.00");
                    graphics.DrawString(totalSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalSalesAmount, fontArial8Regular).Height;
                }

                if (hasServiceCharge == true)
                {
                    String totalServiceChangeLabel = "Service Charge";
                    String totalServiceChangeAmount = totalServiceCharge.ToString("#,##0.00");
                    graphics.DrawString(totalServiceChangeLabel, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalServiceChangeAmount, fontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalServiceChangeAmount, fontArial7Regular).Height;
                }

                String totalDiscountLabel = "Total Discount";
                String totalDiscountAmount = totalDiscount.ToString("#,##0.00");
                graphics.DrawString(totalDiscountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalDiscountAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalDiscountAmount, fontArial8Regular).Height;

                String netSalesLabel = "Net Sales";
                String netSalesAmount = totalSales.ToString("#,##0.00");
                graphics.DrawString(netSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(netSalesAmount, fontArial12Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(netSalesAmount, fontArial12Regular).Height;

                String totalNumberOfItemsLabel = "Total No. of Item(s)\n\n";
                String totalNumberOfItemsQuantity = totalNumberOfItems.ToString("#,##0.00") + "\n\n";
                graphics.DrawString(totalNumberOfItemsLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalNumberOfItemsQuantity, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalNumberOfItemsQuantity, fontArial8Regular).Height;


                // ========
                // 3rd Line
                // ========
                Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) - 7);
                Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) - 7);
                graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);


                // ================
                // Collection Lines
                // ================
                var collectionLines = from d in db.TrnCollectionLines where d.CollectionId == collections.FirstOrDefault().Id select d;
                if (collectionLines.Any())
                {
                    foreach (var collectionLine in collectionLines)
                    {
                        String collectionLineLabel = collectionLine.MstPayType.PayType;
                        String collectionLineAmount = collectionLine.Amount.ToString("#,##0.00");

                        graphics.DrawString(collectionLineLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(collectionLineAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(collectionLineAmount, fontArial8Regular).Height;
                    }
                }

                // ======
                // Change
                // ======
                change = collections.FirstOrDefault().ChangeAmount;

                String changelabel = "Change";
                String changeAmount = change.ToString("#,##0.00");
                graphics.DrawString(changelabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(changeAmount, fontArial12Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(changeAmount, fontArial8Regular).Height;



                // ========
                // 4th Line
                // ========
                Point forthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point forthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, forthLineFirstPoint, forthLineSecondPoint);


                if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType != "ZiJiang Label Printer")
                {
                    // ============
                    // VAT Analysis
                    // ============
                    String vatAnalysisLabel = "\nVAT ANALYSIS";
                    graphics.DrawString(vatAnalysisLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(vatAnalysisLabel, fontArial8Regular).Height + +5.0F;

                    String vatSalesLabel = "VAT Sales";
                    String totalVatSalesAmount = totalVATSales.ToString("#,##0.00");
                    graphics.DrawString(vatSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalVatSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalVatSalesAmount, fontArial8Regular).Height;

                    String totalVATAmountLabel = "VAT Amount";
                    String totalVatAmount = totalVATAmount.ToString("#,##0.00");
                    graphics.DrawString(totalVATAmountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalVatAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalVatAmount, fontArial8Regular).Height;

                    String totalNonVATSalesLabel = "Non-VAT";
                    String totalNonVatAmount = totalNonVATSales.ToString("#,##0.00");
                    graphics.DrawString(totalNonVATSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalNonVatAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalNonVatAmount, fontArial8Regular).Height;

                    //String totalVATExclusiveLabel = "VAT Exclusive";
                    //String totaltotalVATExclusiveAmount = totalVATExclusive.ToString("#,##0.00");
                    //graphics.DrawString(totalVATExclusiveLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    //graphics.DrawString(totaltotalVATExclusiveAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    //y += graphics.MeasureString(totaltotalVATExclusiveAmount, fontArial8Regular).Height;

                    String totalVATExemptLabel = "VAT Exempt";
                    String totaltotalVATExemptAmount = totalVATExempt.ToString("#,##0.00");
                    graphics.DrawString(totalVATExemptLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totaltotalVATExemptAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totaltotalVATExemptAmount, fontArial8Regular).Height;

                    String totalVATZeroRatedLabel = "VAT Zero Rated";
                    String totalVatZeroRatedAmount = totalVATZeroRated.ToString("#,##0.00");
                    graphics.DrawString(totalVATZeroRatedLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(totalVatZeroRatedAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(totalVatZeroRatedAmount, fontArial8Regular).Height;

                    // ========
                    // 5th Line
                    // ========
                    Point sixthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point sixthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, sixthLineFirstPoint, sixthLineSecondPoint);
                }

                // ================
                // Cashier & Server
                // ================
                String cashier = collections.FirstOrDefault().MstUser3.UserName;
                String server = sales.FirstOrDefault().MstUser5.UserName;

                String cashierLabel = "\nCashier";
                String cashierUserData = "\n" + cashier;
                String serverLabel = "Teller";
                String serverUserData = server;
                graphics.DrawString(cashierLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(cashierUserData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(cashierUserData, fontArial8Regular).Height;
                graphics.DrawString(serverLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(serverUserData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(serverUserData, fontArial8Regular).Height;

                // ========
                // 6th Line
                // ========
                Point seventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point seventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, seventhLineFirstPoint, seventhLineSecondPoint);

                if (Modules.SysCurrentModule.GetCurrentSettings().ShowCustomerInfo == false)
                {
                    String soldToLabel = "\nCustomer Name: _______________________";

                    // ==================================
                    // Senior Citizen and PWD Information
                    // ==================================
                    if (collections.FirstOrDefault().SalesId != null)
                    {
                        if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                        {
                            String seniorCitizenID = collections.FirstOrDefault().TrnSale.SeniorCitizenId;
                            String seniorCitizenName = collections.FirstOrDefault().TrnSale.SeniorCitizenName;
                            String seniorCitizenAge = collections.FirstOrDefault().TrnSale.SeniorCitizenAge.ToString();

                            graphics.DrawString("\nSC/PWD ID: " + seniorCitizenID, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenID, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Name: " + seniorCitizenName, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenName, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Age: " + seniorCitizenAge, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenAge, fontArial8Regular).Height;

                            // ========
                            // 7th Line
                            // ========
                            Point eightLineFirstPoint = new Point(0, Convert.ToInt32(y) + 18);
                            Point eightLineSecondPoint = new Point(500, Convert.ToInt32(y) + 18);
                            graphics.DrawLine(blackPen, eightLineFirstPoint, eightLineSecondPoint);

                            soldToLabel = "\n\nCustomer Name: _______________________";
                        }
                    }

                    if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType != "ZiJiang Label Printer")
                    {
                        graphics.DrawString(soldToLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToLabel, fontArial8Regular).Height;

                        String soldToAddressLabel = "Address: _____________________________";
                        graphics.DrawString(soldToAddressLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToAddressLabel, fontArial8Regular).Height;

                        String soldToTINLabel = "TIN: _________________________________";
                        graphics.DrawString(soldToTINLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;

                        String soldToBusinessStyleLabel = "Business Style: ________________________";
                        graphics.DrawString(soldToBusinessStyleLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;
                    }
                    else
                    {
                        soldToLabel = "\nCustomer Name:";
                        graphics.DrawString(soldToLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToLabel, fontArial8Regular).Height;

                        String soldToAddressLabel = "Address:";
                        graphics.DrawString(soldToAddressLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToAddressLabel, fontArial8Regular).Height;
                    }
                }
                else
                {
                    String customerName = collections.FirstOrDefault().TrnSale.MstCustomer.Customer;
                    Decimal customerAvailableReward = collections.FirstOrDefault().TrnSale.MstCustomer.AvailableReward;
                    Decimal customerAvailableLoad = collections.FirstOrDefault().TrnSale.MstCustomer.LoadAmount;
                    String customerAddress = collections.FirstOrDefault().TrnSale.MstCustomer.Address;
                    String customerTIN = collections.FirstOrDefault().TrnSale.MstCustomer.TIN;
                    String customerBusinessStyle = collections.FirstOrDefault().TrnSale.MstCustomer.BusinessStyle;
                    
                    

                    // ==================================
                    // Senior Citizen and PWD Information
                    // ==================================
                    if (collections.FirstOrDefault().SalesId != null)
                    {
                        if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                        {
                            String seniorCitizenID = collections.FirstOrDefault().TrnSale.SeniorCitizenId;
                            String seniorCitizenName = collections.FirstOrDefault().TrnSale.SeniorCitizenName;
                            String seniorCitizenAge = collections.FirstOrDefault().TrnSale.SeniorCitizenAge.ToString();

                            graphics.DrawString("\nSC/PWD ID: " + seniorCitizenID, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenID, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Name: " + seniorCitizenName, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenName, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Age: " + seniorCitizenAge, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenAge, fontArial8Regular).Height;

                            // ========
                            // 7th Line
                            // ========
                            Point eightLineFirstPoint = new Point(0, Convert.ToInt32(y) + 18);
                            Point eightLineSecondPoint = new Point(500, Convert.ToInt32(y) + 18);
                            graphics.DrawLine(blackPen, eightLineFirstPoint, eightLineSecondPoint);

                            //soldToLabel = "\n\nCustomer Name: " + customerName;
                        }
                    }

                    String soldToLabel = "\nCustomer Name: " + customerName;
                    graphics.DrawString(soldToLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToLabel, fontArial8Regular).Height;

                    String soldToAddressLabel = "Address: " + customerAddress;
                    graphics.DrawString(soldToAddressLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToAddressLabel, fontArial8Regular).Height;

                    if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType != "ZiJiang Label Printer")
                    {
                        String soldToTINLabel = "TIN: " + customerTIN;
                        graphics.DrawString(soldToTINLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;

                        String soldToBusinessStyleLabel = "Business Style: " + customerBusinessStyle;
                        graphics.DrawString(soldToBusinessStyleLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;
                    }

                    String customerAvailableRewaredLabel = "Available Reward: " + customerAvailableReward.ToString("#,##0.00");
                    graphics.DrawString(customerAvailableRewaredLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(customerAvailableRewaredLabel, fontArial8Regular).Height;

                    String customerAvailableRewaredLoad = "Available Load: " + customerAvailableLoad.ToString("#,##0.00");
                    graphics.DrawString(customerAvailableRewaredLoad, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(customerAvailableRewaredLoad, fontArial8Regular).Height;
                }

                // ========
                // 8th Line
                // ========
                Point ninethLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point ninethLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, ninethLineFirstPoint, ninethLineSecondPoint);

                String remarks = "\nRemarks: " + sales.FirstOrDefault().Remarks;
                RectangleF remarksDataRectangle = new RectangleF
                {
                    X = x,
                    Y = y,
                    Size = new Size(250, ((int)graphics.MeasureString(remarks, fontArial8Regular, 250, StringFormat.GenericDefault).Height))
                };
                graphics.DrawString(remarks, fontArial8Regular, Brushes.Black, remarksDataRectangle, drawFormatLeft);
                y += remarksDataRectangle.Size.Height;

                //// =========
                //// 10th Line
                //// =========
                //Point tenthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                //Point tenthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                //graphics.DrawLine(blackPen, tenthLineFirstPoint, tenthLineSecondPoint);

                //String orderNumber = "\nOrder Number: \n\n " + collections.FirstOrDefault().TrnSale.SalesNumber;
                //graphics.DrawString(orderNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                //y += graphics.MeasureString(orderNumber, fontArial8Regular).Height;

                if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType != "ZiJiang Label Printer")
                {
                    // =========
                    // 8th Line
                    // =========
                    Point eleventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point eleventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, eleventhLineFirstPoint, eleventhLineSecondPoint);

                    String receiptFooter = "\n" + systemCurrent.ReceiptFooter;
                    graphics.DrawString(receiptFooter, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString(receiptFooter, fontArial8Regular).Height;
                }
            }
        }
    }
}

