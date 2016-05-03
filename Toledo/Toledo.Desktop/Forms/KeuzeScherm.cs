using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Toledo.Desktop.Data;
using Toledo.Desktop.Helpers;

using static Toledo.Desktop.Properties.Settings;

namespace Toledo.Desktop.Forms
{
    public partial class KeuzeScherm : CustomMetroForm
    {
        private Beheren _ab;
        private Verkopen _v;
        private Instellingen _i;

        public KeuzeScherm()
        {
            InitializeComponent();
            ListenForBarcodes();
        }

        private void KeuzeScherm_Load(object sender, EventArgs e)
        {
            _ab = new Beheren();
            _v = new Verkopen();
            _i = new Instellingen();

            string filename;

            try
            {
                var csb = new SqlConnectionStringBuilder(Program.Settings.ConnectionString);
                filename = csb.AttachDBFilename;
            }
            catch
            {
                filename = null;
            }

            dbFilename.Text = filename;
        }

        private void artikelenBeherenBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dbFilename.Text))
            {
                _ab.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(this, "Selecteer eerst een database.", "Database niet gevonden", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void verkopenBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dbFilename.Text))
            {
                _v.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(this, "Selecteer eerst een database.", "Database niet gevonden", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void bestandInladenBtn_Click(object sender, EventArgs e)
        {
            
            if (openDatabaseFile.ShowDialog() != DialogResult.OK)
                return;

            var cs = string.Format(Program.Settings.ConnectionStringTemplate, openDatabaseFile.FileName);

            using (var db = new ToledoDb(cs))
            {
                if (!db.Database.Exists())
                {
                    MessageBox.Show(this, "Database kon niet worden geladen!", "Fout!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Program.Settings.ConnectionString = cs;
                    Program.Settings.Save();
                    dbFilename.Text = openDatabaseFile.FileName;
                }
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            _i.ShowDialog(this);
        }
    }
}
