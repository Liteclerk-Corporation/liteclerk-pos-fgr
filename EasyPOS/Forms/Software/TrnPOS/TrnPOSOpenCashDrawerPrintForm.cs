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
    public partial class TrnPOSOpenCashDrawerPrintForm : Form
    {
        public Int32 user = 0;
        public TrnPOSOpenCashDrawerPrintForm(Int32 userId)
        {
            InitializeComponent();
            user = userId;

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                printDocumentOpenCashDrawer.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                printDocumentOpenCashDrawer.Print();
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                printDocumentOpenCashDrawer.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 280, 38500);
                printDocumentOpenCashDrawer.Print();
            }
            else
            {
                printDocumentOpenCashDrawer.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                printDocumentOpenCashDrawer.Print();
            }
        }

        private void printDocumentOpenCashDrawer_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

            // =================
            // Print Title
            // =================
            String printTitle = "O P E N  C A S H  D R A W E R";
            graphics.DrawString(printTitle, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(printTitle, fontArial8Regular).Height;

            // ============
            // Sales Header
            // ============
            var users = from d in db.MstUsers
                        where d.Id == user
                        select d;

            if (users.Any())
            {
                String openedBy = "Opened By: " + users.FirstOrDefault().FullName;
                graphics.DrawString(openedBy, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(openedBy, fontArial8Regular).Height;

                String openedDateTime = "Opened Date/Time : " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                graphics.DrawString(openedDateTime, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(openedDateTime, fontArial8Regular).Height;
            }
        }
    }
}
