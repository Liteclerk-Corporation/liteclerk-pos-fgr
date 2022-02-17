using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Account.SysLogin
{
    public partial class SysLoginOpenDrawerForm : Form
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        public SysLoginOpenDrawerForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }
        public void Authenticate()
        {
            var user = from d in db.MstUsers
                       where d.UserName == textBoxUsername.Text
                       && d.Password == textBoxPassword.Text
                       select d;

            if (user.Any())
            {
                Boolean canOpenDrawer = user.FirstOrDefault().CanOpenDrawer;
                if (canOpenDrawer == true)
                {
                    new Software.TrnPOS.TrnPOSOpenCashDrawerPrintForm(user.FirstOrDefault().Id);

                    Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                    {
                        UserId = user.FirstOrDefault().Id,
                        AuditDate = DateTime.Now,
                        TableInformation = "TrnSales",
                        RecordInformation = "",
                        FormInformation = "",
                        ActionInformation = "Open Cash Drawer"
                    };
                    Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                    db.SubmitChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Not Authorized to Open Cash Drawer!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User doesn't exist!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }
    }
}
