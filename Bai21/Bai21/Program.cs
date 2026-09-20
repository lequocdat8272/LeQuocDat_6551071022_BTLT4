using System;
using System.Windows.Forms;

namespace Bai21
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Show splash form first (modal). When it closes, start main MDI form.
            using (var splash = new frmSplash())
            {
                splash.ShowDialog();
            }

            Application.Run(new frmMain());
        }
    }
}
