using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Toledo.Desktop.Helpers;

namespace Toledo.Desktop.Forms
{
    public partial class Bevestiging : CustomMetroForm
    {
        public Bevestiging(string message)
        {
            InitializeComponent();
            okBtn.BackColor = okBtn.Style.ToColor();
            

        }
    }
}
