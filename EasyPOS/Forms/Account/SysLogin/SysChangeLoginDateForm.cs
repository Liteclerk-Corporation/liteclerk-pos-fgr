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
    public partial class SysChangeLoginDateForm : Form
    {
        public SysLoginForm sysLoginForm;
        public SysChangeLoginDateForm(SysLoginForm loginForm)
        {
            InitializeComponent();

            sysLoginForm = loginForm;
            var settings = Modules.SysCurrentModule.GetCurrentSettings();
            dateTimePickerLoginDate.Value = Convert.ToDateTime(settings.DateLogin);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult changeLoginDateDialogResult = MessageBox.Show("Confirm changes?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (changeLoginDateDialogResult == DialogResult.Yes)
            {
                sysLoginForm.dateTimePickerLoginDate.Value = dateTimePickerLoginDate.Value;
                Close();
            }
        }
    }
}
