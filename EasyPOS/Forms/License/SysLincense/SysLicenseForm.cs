using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.License.SysLicense
{
    public partial class SysLicenseForm : Form
    {
        public SysLicenseForm()
        {
            InitializeComponent();
            GetSerialNumber();

            textBoxLicenseCode.Focus();

            labelVersion.Text = "EasyPOS Version: " + Modules.SysCurrentModule.GetCurrentSettings().CurrentVersion;
            labelSupport.Text = "Support: Easyfis Corporation " + Modules.SysCurrentModule.GetCurrentSettings().CurrentSupport;
        }

        public void GetSerialNumber()
        {
            try
            {
                textBoxSerialNumber.Text = Modules.SysLicenseModule.GetSerialNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VerifyLicenseCode()
        {
            try
            {
                if (Modules.SysLicenseModule.DecryptLicenseCodeToSerialNumber(textBoxLicenseCode.Text) == Modules.SysLicenseModule.GetSerialNumber())
                {
                    Modules.SysCurrentModule.UpdateCurrentSettingsLicenseCode(textBoxLicenseCode.Text);

                    Hide();

                    Account.SysLogin.SysLoginForm sysLoginForm = new Account.SysLogin.SysLoginForm(null, null, null);
                    sysLoginForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid License Code.", "Easy ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            VerifyLicenseCode();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SysLicenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBoxLicenseCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerifyLicenseCode();
            }
        }
    }
}