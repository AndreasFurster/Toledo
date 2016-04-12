﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Toledo.Desktop.Helpers;

namespace Toledo.Desktop.Forms
{
    public partial class KeuzeScherm : CustomMetroForm
    {
        private Beheren _ab;
        private Verkopen _v;

        public KeuzeScherm()
        {
            InitializeComponent();
            ListenForBarcodes();
        }

        private void KeuzeScherm_Load(object sender, EventArgs e)
        {
            _ab = new Beheren();
            _v = new Verkopen();
        }

        private void artikelenBeherenBtn_Click(object sender, EventArgs e)
        {
            _ab.ShowDialog(this);        
        }

        private void verkopenBtn_Click(object sender, EventArgs e)
        {
            _v.ShowDialog(this);
        }
    }
}
