using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toledo.Desktop.Helpers;
using Toledo.Desktop.Models;

namespace Toledo.Desktop.Forms
{
    public partial class Afrekenen : CustomMetroForm
    {
        public BetaalMethode BetaalMethode;

        public Afrekenen(decimal total)
        {
            InitializeComponent();
            BetaalMethode = BetaalMethode.Onbekend;
        }

        private void contantBtn_Click(object sender, EventArgs e)
        {
            BetaalMethode = BetaalMethode.Contant;
        }

        private void pinnenBtn_Click(object sender, EventArgs e)
        {
            BetaalMethode = BetaalMethode.Pinnen;
        }
    }
}
