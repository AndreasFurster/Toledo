using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Toledo.Desktop.Forms;
using Toledo.Desktop.Properties;

namespace Toledo.Desktop
{
    static class Program
    {
        public static Settings Settings = Settings.Default;
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
