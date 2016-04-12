using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toledo.Desktop.Models
{
    enum BtwTarief
    {
        [Description("21%")]
        Btw21 = 21,

        [Description("6%")]
        Btw6 = 6,

        [Description("0%")]
        Btw0 = 0
    }
}
