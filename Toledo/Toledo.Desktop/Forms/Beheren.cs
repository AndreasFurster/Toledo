using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Toledo.Desktop.Forms;

namespace Toledo.Desktop
{
    public partial class Beheren : CustomMetroForm
    {
        public Beheren()
        {
            InitializeComponent();
            ListenForBarcodes();
            BarcodeInput += new BarcodeInputHandler(ArtikelenBeheren_BarcodeInput);
        }

        private void ArtikelenBeheren_BarcodeInput(object sender, BarcodeInputEventArgs e)
        {
            var ba = new BeheerArtikel(e.Barcode);
            ba.ShowDialog(this);
        }

        private void Beheren_Load(object sender, EventArgs e)
        {

        }

        private void Beheren_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
