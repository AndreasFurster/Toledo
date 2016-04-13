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
        private ToledoDb _db = new ToledoDb();
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

            standaardPrijsInclBtw.Text = _artikel.StandaardPrijsInclBtw.ToString();
            standaardPrijsExclBtw.Text = SubtractBtw(_artikel.StandaardPrijsInclBtw, _artikel.BtwTarief)?.ToString("0.00");

            kortingsPrijsInclBtw.Text = _artikel.KortingsPrijsInclBtw.ToString();
            kortingsPrijsExclBtw.Text = SubtractBtw(_artikel.KortingsPrijsInclBtw, _artikel.BtwTarief)?.ToString("0.00");

            categorie.DataSource = _db.Categorieen.ToArray();
            categorie.SelectedIndex = categorie.FindStringExact(_artikel.Categorie?.Name);

            leverbaar.Checked = _artikel.Leverbaar;
        }

        private void opslaanBtn_Click(object sender, EventArgs e)
        {
            _artikel.Omschrijving = omschrijving.Text;

            if (btw21.Checked) _artikel.BtwTarief = BtwTarief.Btw21;
            if (btw6.Checked) _artikel.BtwTarief = BtwTarief.Btw6;
            if (btw0.Checked) _artikel.BtwTarief = BtwTarief.Btw0;

            decimal standaardPrijs;
            var heeftStandaardPrijs = decimal.TryParse(standaardPrijsInclBtw.Text, out standaardPrijs);

            decimal kortingsPrijs;
            var heeftKortingsPrijs = decimal.TryParse(kortingsPrijsExclBtw.Text, out kortingsPrijs);

            _artikel.StandaardPrijsInclBtw = heeftStandaardPrijs ? standaardPrijs : (decimal?) null;
            _artikel.KortingsPrijsInclBtw = heeftKortingsPrijs ? kortingsPrijs : (decimal?) null;

            var cat = _db.Categorieen.SingleOrDefault(c => c.Name == categorie.Text) ?? _db.Categorieen.Add(new Categorie(categorie.Text));

            _artikel.Categorie = cat;

            _artikel.Leverbaar = leverbaar.Checked;

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

        private void standaardPrijsExclBtw_KeyUp(object sender, KeyEventArgs e)
        {
            decimal exclPrijs = 0;
            if (!decimal.TryParse(standaardPrijsExclBtw.Text, out exclPrijs))
            {
                standaardPrijsExclBtw.Tag = "error";
            }
            else
            {
                standaardPrijsInclBtw.Text = AddBtw(exclPrijs, GetBtwTarief())?.ToString("0.00");
                standaardPrijsExclBtw.Tag = null;
            }
        }

        private void standaardPrijsInclBtw_KeyUp(object sender, KeyEventArgs e)
        {
            decimal inclPrijs = 0;
            if (!decimal.TryParse(standaardPrijsInclBtw.Text, out inclPrijs))
            {
                standaardPrijsInclBtw.Tag = "error";
            }
            else
            {
                standaardPrijsExclBtw.Text = SubtractBtw(inclPrijs, GetBtwTarief())?.ToString("0.00");
                standaardPrijsInclBtw.Tag = null;
            }
        }

        private void kortingsPrijsExclBtw_KeyUp(object sender, KeyEventArgs e)
        {
            decimal exclPrijs = 0;
            if (!decimal.TryParse(kortingsPrijsExclBtw.Text, out exclPrijs))
            {
                kortingsPrijsExclBtw.Tag = "error";
            }
            else
            {
                kortingsPrijsInclBtw.Text = AddBtw(exclPrijs, GetBtwTarief())?.ToString("0.00");
                kortingsPrijsExclBtw.Tag = null;
            }
        }

        private void kortingsPrijsInclBtw_KeyUp(object sender, KeyEventArgs e)
        {
            decimal inclPrijs = 0;
            if (!decimal.TryParse(kortingsPrijsInclBtw.Text, out inclPrijs))
            {
                standaardPrijsInclBtw.Tag = "error";
            }
            else
            {
                kortingsPrijsExclBtw.Text = SubtractBtw(inclPrijs, GetBtwTarief())?.ToString("0.00");
                kortingsPrijsInclBtw.Tag = null;
            }
        }
    }
}
