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

namespace Toledo.Desktop
{
    public partial class ArtikelenBeheren : CustomMetroForm
    {
        public ArtikelenBeheren()
        {
            InitializeComponent();
            ListenForBarcodes();
            BarcodeInput += new BarcodeInputHandler(ArtikelenBeheren_BarcodeInput);
        }

        private void ArtikelenBeheren_BarcodeInput(object sender, BarcodeInputEventArgs e)
        {
            metroTextBox1.Text = e.Barcode;
        }

        private void ArtikelenBeheren_Load(object sender, EventArgs e)
        {

        }

        private void ArtikelenBeheren_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
