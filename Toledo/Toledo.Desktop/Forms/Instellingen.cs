using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toledo.Desktop.Data;
using Toledo.Desktop.Helpers;

namespace Toledo.Desktop.Forms
{
    public partial class Instellingen : CustomMetroForm
    {
        public Instellingen()
        {
            InitializeComponent();
        }

        private void newDatabase_Click(object sender, EventArgs e)
        {
            if (saveNewDatabase.ShowDialog() != DialogResult.OK)
                return;

            var path = saveNewDatabase.FileName;

            var cs = string.Format(Program.Settings.ConnectionStringTemplate, path);

            var db = new ToledoDb(cs);

            db.Database.Delete();
            db.Database.Create();

            Program.Settings.ConnectionString = cs;
            Program.Settings.Save();
        }
    }
}
