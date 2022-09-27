using System;
using System.Windows.Forms;

namespace EasyPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String licenseCode = Modules.SysCurrentModule.GetCurrentSettings().LicenseCode;

            if (String.IsNullOrEmpty(licenseCode) == true)
            {
                Application.Run(new Forms.License.SysLicense.SysLicenseForm());
            }
            else if (Modules.SysLicenseModule.DecryptLicenseCodeToSerialNumber(licenseCode) == Modules.SysLicenseModule.GetSerialNumber())
            {
                Application.Run(new Forms.Account.SysLogin.SysLoginForm(null,null,null));
            }
            else
            {
                Application.Run(new Forms.License.SysLicense.SysLicenseForm());
            }
        }
    }
}
