using System;
using System.Windows.Forms;
using Toledo.Desktop.Forms;

namespace Toledo.Desktop
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
            Application.Run(new KeuzeScherm());
        }
    }
}
