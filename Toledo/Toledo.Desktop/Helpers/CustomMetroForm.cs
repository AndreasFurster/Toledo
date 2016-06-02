using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Toledo.Desktop.Helpers
{
    public class CustomMetroForm : MetroForm
    {
        public event BarcodeInputHandler BarcodeInput;
        public delegate void BarcodeInputHandler(object sender, BarcodeInputEventArgs e);

        private readonly Regex _barcodeRegex = new Regex("([0-9]{13})");

        private string _pressedKeys = string.Empty;

        protected void ListenForBarcodes()
        {
            KeyPreview = true;
            KeyPress += ScannerInput;
        }

        private void ScannerInput(object sender, KeyPressEventArgs e)
        {
            _pressedKeys += e.KeyChar;
            var mc = _barcodeRegex.Match(_pressedKeys);

            if (mc.Success)
            {
                BarcodeInput?.Invoke(this, new BarcodeInputEventArgs(mc.Groups[1].Value));

                _pressedKeys = string.Empty;
            }
        }

        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMetroForm));
            SuspendLayout();
            // 
            // CustomMetroForm
            // 
            ClientSize = new System.Drawing.Size(284, 261);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            Location = new System.Drawing.Point(0, 0);
            Name = "CustomMetroForm";
            ResumeLayout(false);

        }
    }

    public class BarcodeInputEventArgs : EventArgs
    {
        public string Barcode { get; set; }

        public BarcodeInputEventArgs(string barcode)
        {
            Barcode = barcode;
        }
    }
}
