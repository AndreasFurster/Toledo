using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Toledo.Desktop
{
    public class CustomMetroForm : MetroForm
    {
        public event BarcodeInputHandler BarcodeInput;
        public delegate void BarcodeInputHandler(object sender, BarcodeInputEventArgs e);

        private Regex BarcodeRegex = new Regex("###([0-9]{12,13})###");

        private string PressedKeys = string.Empty;

        protected void ListenForBarcodes()
        {
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(ScannerInput);
        }

        private void ScannerInput(object sender, KeyPressEventArgs e)
        {
            PressedKeys += e.KeyChar;
            var mc = BarcodeRegex.Match(PressedKeys);

            if (mc.Success)
            {
                if(BarcodeInput != null)
                {
                    BarcodeInput(this, new BarcodeInputEventArgs(mc.Groups[1].Value));
                }

                PressedKeys = string.Empty;
            }
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
