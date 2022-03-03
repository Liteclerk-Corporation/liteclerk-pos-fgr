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
    public partial class TrnPOSTouchDeletedItemsForm : Form
    {
        public String kitchenReport = "";

        public TrnPOSTouchDeletedItemsForm(String printerName)
        {
            InitializeComponent();

            // ============
            // Data Context
            // ============
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            if (String.IsNullOrEmpty(printerName) == false)
            {
                printDocumentDeletedItems.PrinterSettings.PrinterName = printerName;
                printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                printDocumentDeletedItems.Print();
            }
            else
            {
                var salesLineDeletedList = from d in db.TrnSalesLineDeleteds
                                           where d.IsPrinted == false
                                           && d.ItemDescription != "Service Charge"
                                           select d;

                if (salesLineDeletedList.Any())
                {
                    List<String> kitchenReports = new List<String>();
                    List<Entities.TrnSalesLineDeletedEntity> salesLineListDeletedEnity = new List<Entities.TrnSalesLineDeletedEntity>();

                    foreach (var deletedItems in salesLineDeletedList)
                    {

                        var salesLineDeletedItemReports = from d in salesLineDeletedList
                                                          select d;

                        if (salesLineDeletedItemReports.Any())
                        {
                            if (salesLineDeletedItemReports.ToList().Any())
                            {
                                foreach (var salesLineDeletedItemReport in salesLineDeletedItemReports.ToList())
                                {
                                    if (kitchenReports.Contains(salesLineDeletedItemReport.ItemKitchen) == false)
                                    {
                                        kitchenReports.Add(salesLineDeletedItemReport.ItemKitchen);
                                    }
                                }
                            }
                        }
                    }

                    if (kitchenReports.Any())
                    {
                        var groupKitchenReports = from d in kitchenReports select d;

                        if (groupKitchenReports.ToList().Any())
                        {
                            foreach (var groupKitchenReport in groupKitchenReports.ToList())
                            {
                                kitchenReport = groupKitchenReport;

                                Controllers.SysKitchenPrinterController sysKitchenPrinterController = new Controllers.SysKitchenPrinterController();
                                var kitchenPrinters = sysKitchenPrinterController.KitchenPerKitchenNumber(kitchenReport);

                                if (kitchenPrinters.Any())
                                {
                                    printDocumentDeletedItems.PrinterSettings.PrinterName = kitchenPrinters.FirstOrDefault().PrinterName;
                                    printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize(kitchenPrinters.FirstOrDefault().Alias, kitchenPrinters.FirstOrDefault().DefaultWidth, kitchenPrinters.FirstOrDefault().DefaultHeight);
                                    printDocumentDeletedItems.Print();
                                }
                            }
                        }
                        else
                        {
                            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
                            {
                                printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                                printDocumentDeletedItems.Print();
                            }
                            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
                            {
                                printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 280, 38500);
                                printDocumentDeletedItems.Print();
                            }
                            else
                            {
                                printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                                printDocumentDeletedItems.Print();
                            }
                        }
                    }
                    else
                    {
                        if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
                        {
                            printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                            printDocumentDeletedItems.Print();
                        }
                        else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
                        {
                            printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 280, 38500);
                            printDocumentDeletedItems.Print();
                        }
                        else
                        {
                            printDocumentDeletedItems.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                            printDocumentDeletedItems.Print();
                        }
                    }
                }
            }
        }


        private void printDocumentDeletedItems_PrintPage(object sender, PrintPageEventArgs e)
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
            Font fontArial10Bold = new Font("Arial", 10, FontStyle.Bold);
            Font fontArial10Regular = new Font("Arial", 10, FontStyle.Regular);
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

            // ============
            // Sales Header
            // ============
            var salesLineDeletedItem = from d in db.TrnSalesLineDeleteds
                                       where d.IsPrinted == false
                                       select d;

            if (salesLineDeletedItem.Any())
            {
                String spaceHeader = "";
                graphics.DrawString(spaceHeader, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(spaceHeader, fontArial10Regular).Height + 100F;

                String collectionNumberText = salesLineDeletedItem.FirstOrDefault().SalesNumber;
                graphics.DrawString(collectionNumberText, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionNumberText, fontArial10Regular).Height;


                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

                // ==========
                // Sales Line
                // ==========
                String itemLabel = "\nITEM";
                graphics.DrawString(itemLabel, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                y += graphics.MeasureString(itemLabel, fontArial10Regular).Height + 5.0F;

                if (salesLineDeletedItem.FirstOrDefault().ItemDescription != "Service Charge")
                {
                    String itemData = salesLineDeletedItem.FirstOrDefault().ItemDescription + "\n" + salesLineDeletedItem.FirstOrDefault().Quantity.ToString("#,##0.00") + " " + salesLineDeletedItem.FirstOrDefault().Unit + " " + salesLineDeletedItem.FirstOrDefault().Preparation;
                    RectangleF itemDataRectangle = new RectangleF
                    {
                        X = x,
                        Y = y,
                        Size = new Size(180, ((int)graphics.MeasureString(itemData, fontArial10Regular, 150, StringFormat.GenericDefault).Height))
                    };
                    graphics.DrawString(itemData, fontArial10Regular, Brushes.Black, itemDataRectangle, drawFormatLeft);

                    y += itemDataRectangle.Size.Height + 3.0F;
                }

                // ========
                // 2nd Line
                // ========
                Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

                // ========
                // 3rd Line
                // ========
                Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);

                String remarks = "\nITEM DELETED";
                graphics.DrawString(remarks, fontArial10Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(remarks, fontArial10Bold).Height + 1.0F;

                // ========
                // 5th Line
                // ========
                Point fifthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point fifthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, fifthLineFirstPoint, fifthLineSecondPoint);

                // =======
                // Cashier
                // =======
                String cashier = salesLineDeletedItem.FirstOrDefault().UserName;

                String cashierLabel = "\nTeller:";
                String cashierUserData = "\n" + cashier;
                graphics.DrawString(cashierLabel, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(cashierUserData, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(cashierUserData, fontArial10Regular).Height;

                // ========
                // 6th Line
                // ========
                Point sixthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point sixthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, sixthLineFirstPoint, sixthLineSecondPoint);

                String collectionDateText = "\n" + salesLineDeletedItem.FirstOrDefault().SalesDate.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionDateText, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);

                String collectionTimeText = "\n" + salesLineDeletedItem.FirstOrDefault().DeletedDate.ToString("H:mm:ss", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionTimeText, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(collectionTimeText, fontArial10Regular).Height;

                String tableNoText = "\nTable: " + salesLineDeletedItem.FirstOrDefault().TableCode;
                graphics.DrawString(tableNoText, fontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(tableNoText, fontArial10Regular).Height;
            }
        }
    }
}
