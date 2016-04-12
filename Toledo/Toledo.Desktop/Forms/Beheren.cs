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
using Toledo.Desktop.Data;
using System.Reflection;
using Toledo.Desktop.Helpers;
using Toledo.Desktop.Models;

namespace Toledo.Desktop.Forms
{
    public partial class Beheren : CustomMetroForm
    {
        public Beheren()
        {
            InitializeComponent();
            ListenForBarcodes();
            BarcodeInput += new BarcodeInputHandler(ArtikelenBeheren_BarcodeInput);
        }

        private void Beheren_Load(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(this, null);
        }

        private void ArtikelenBeheren_BarcodeInput(object sender, BarcodeInputEventArgs e)
        {
            var ba = new BeheerArtikel(e.Barcode);
            ba.ShowDialog(this);
        }


        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 1:
                    LoadArtikelenLijst();
                    break;
            }
        }

        private void LoadArtikelenLijst()
        {
            using (var db = new ToledoDb())
            {
                var artikelen = db.Artikelen.Include("Categorie").AsEnumerable().Select(a =>
                {
                    var btwDescription = string.Empty;
                    var name = Enum.GetName(a.BtwTarief.GetType(), a.BtwTarief);
                    if (name != null)
                    {
                        var field = a.BtwTarief.GetType().GetField(name);
                        if (field != null)
                        {
                            var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                            if (attr != null)
                            {
                                btwDescription = attr.Description;
                            }
                        }
                    };

                    return new
                    {
                        barcode = a.Barcode,
                        omschrijving = a.Omschrijving,
                        btw = btwDescription,
                        categorie = a.Categorie,
                        prijs = a.Prijs
                    };
                }).ToList();
                artikelenLijst.DataSource = artikelen;
            }
        }

        private void artikelenLijst_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            var senderGrid = (DataGridView) sender;

            var dbi = senderGrid.Rows[e.RowIndex].DataBoundItem;
            var barcode = dbi.GetType().GetProperty("barcode").GetValue(dbi).ToString();

            var ba = new BeheerArtikel(barcode);
            if (ba.ShowDialog(this) == DialogResult.OK)
            {
                LoadArtikelenLijst();
            }
        }
    }
}
