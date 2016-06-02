using System;
using System.Linq;
using System.Windows.Forms;
using Toledo.Desktop.Models;
using Toledo.Desktop.Data;
using System.Data.Entity;
using Toledo.Desktop.Helpers;

namespace Toledo.Desktop.Forms
{
    public partial class BeheerArtikel : CustomMetroForm
    {
        private readonly ToledoDb _db = new ToledoDb();
        private Artikel _artikel;

        public BeheerArtikel(string barcode)
        {
            var artikel = _db.Artikelen.SingleOrDefault(a => a.Barcode == barcode);

            _artikel = artikel ?? new Artikel {Barcode = barcode};

            InitializeComponent();
        }

        private void BeheerArtikel_Load(object sender, EventArgs e)
        {
            artikelCode.Text = _artikel.Barcode;
            omschrijving.Text = _artikel.Omschrijving;

            switch (_artikel.BtwTarief)
            {
                case BtwTarief.Btw21:
                    btw21.Checked = true;
                    break;
                case BtwTarief.Btw6:
                    btw6.Checked = true;
                    break;
                case BtwTarief.Btw0:
                    btw0.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            prijsInclBtw.Text = _artikel.PrijsInclBtw.ToString("0.00");
            prijsExclBtw.Text = SubtractBtw(_artikel.PrijsInclBtw, _artikel.BtwTarief)?.ToString("0.00");

            categorie.DataSource = _db.Categorieen.ToArray();
            categorie.SelectedIndex = categorie.FindStringExact(_artikel.Categorie?.Name);
        }

        private void opslaanBtn_Click(object sender, EventArgs e)
        {
            _artikel.Omschrijving = omschrijving.Text;

            _artikel.BtwTarief = GetBtwTarief();

            decimal prijs;
            var heeftPrijs = decimal.TryParse(prijsInclBtw.Text, out prijs);

            if (!heeftPrijs)
            {
                prijs = 0;
            }

            _artikel.PrijsInclBtw = prijs;

            var cat = _db.Categorieen.SingleOrDefault(c => c.Name == categorie.Text) ?? _db.Categorieen.Add(new Categorie(categorie.Text));

            _artikel.Categorie = cat;

            if (_db.Artikelen.Any(a => a.Id == _artikel.Id))
            {
                _db.Artikelen.Attach(_artikel);
                _db.Entry(_artikel).State = EntityState.Modified;
            }
            else
            {
                _db.Artikelen.Add(_artikel);
            }

            _db.SaveChanges();
            Close();
        }

        private decimal? AddBtw(decimal? value, BtwTarief btw)
        {
            if (value == null)
            {
                return null;
            }
            return value.Value*((int) btw + 100)/100;
        }

        private decimal? SubtractBtw(decimal? value, BtwTarief btw)
        {
            if (value == null)
            {
                return null;
            }
            return value.Value/(100 + (int) btw)*100;
        }

        private BtwTarief GetBtwTarief()
        {
            if (btw6.Checked)
                return BtwTarief.Btw6;

            if (btw0.Checked)
                return BtwTarief.Btw0;

            return BtwTarief.Btw21;
        }

        private void prijsExclBtw_KeyUp(object sender, KeyEventArgs e)
        {
            decimal exclPrijs;
            if (!decimal.TryParse(prijsExclBtw.Text, out exclPrijs))
            {
                prijsExclBtw.Tag = "error";
            }
            else
            {
                prijsInclBtw.Text = AddBtw(exclPrijs, GetBtwTarief())?.ToString("0.00");
                prijsExclBtw.Tag = null;
            }
        }

        private void prijsInclBtw_KeyUp(object sender, KeyEventArgs e)
        {
            decimal inclPrijs;
            if (!decimal.TryParse(prijsInclBtw.Text, out inclPrijs))
            {
                prijsInclBtw.Tag = "error";
            }
            else
            {
                prijsExclBtw.Text = SubtractBtw(inclPrijs, GetBtwTarief())?.ToString("0.00");
                prijsInclBtw.Tag = null;
            }
        }
    }
}
