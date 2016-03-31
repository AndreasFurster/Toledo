using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toledo.Desktop.Forms
{
    public partial class BeheerArtikel : CustomMetroForm
    {
        private string Barcode;

        public BeheerArtikel(string barcode)
        {
            Barcode = barcode;
            InitializeComponent();
        }

        private void BeheerArtikel_Load(object sender, EventArgs e)
        {
            artikelCode.Text = Barcode;
        }
    }
}
