﻿using System;
using System.Collections.Generic;
using System.Data;
using MetroFramework.Forms;

namespace Toledo.Desktop
{
    public partial class Verkopen : CustomMetroForm
    {
        public Verkopen()
        {
            InitializeComponent();
            ListenForBarcodes();
        }

        private void Verkopen_Load(object sender, EventArgs e)
        {

        }   
    }
}
