using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Toledo.Desktop.Data;
using Toledo.Desktop.Helpers;
using Toledo.Desktop.Models;

namespace Toledo.Desktop.Forms
{
    public partial class Verkopen : CustomMetroForm
    {
        private Verkoop _verkoop;
        private Afrekenen _afrekenen;

        public Verkopen()
        { 
            InitializeComponent();
            ListenForBarcodes();

            _verkoop = new Verkoop();
            

            BarcodeInput += Verkopen_BarcodeInput;
        }

        private void Verkopen_BarcodeInput(object sender, BarcodeInputEventArgs e)
        {
            using (var db = new ToledoDb())
            {
                var artikel = db.Artikelen.SingleOrDefault(a => a.Barcode == e.Barcode);

                if (artikel == null)
                {
                    return;
                }

                _verkoop.Artikelen.Add(artikel);
                db.Verkopen.AddOrUpdate(_verkoop);
                var task = db.SaveChangesAsync();
                ReloadGrid();
                task.Wait();
            }
        }

        private void ReloadGrid()
        {
            var rows = new List<object>();
            var artikelen = _verkoop.Artikelen.GroupBy(a => a.Barcode);

            foreach (var artikelgroep in artikelen)
            {
                rows.Add(new
                {
                    barcode = artikelgroep.Key,
                    aantal = artikelgroep.Count(),
                    beschrijving = artikelgroep.First().Omschrijving,
                    prijsPerStuk = artikelgroep.First().PrijsInclBtw,
                    prijsTotaal = artikelgroep.Sum(a => a.PrijsInclBtw)
                });
            }

            verkopenGrid.DataSource = rows;
        }

        private void Verkopen_Load(object sender, EventArgs e)
        {
        }

        private void afrekenenBtn_Click(object sender, EventArgs e)
        {
            _afrekenen = new Afrekenen(_verkoop.Artikelen.Sum(a => a.PrijsInclBtw));
            if (_afrekenen.ShowDialog(this) == DialogResult.OK)
            {
                _verkoop.BetaalMethode = _afrekenen.BetaalMethode;
                _verkoop.VerkoopDatum = DateTime.Now;

                using (var db = new ToledoDb())
                {
                    db.Verkopen.AddOrUpdate(_verkoop);
                    db.SaveChangesAsync();
                    _verkoop = new Verkoop();
                    ReloadGrid();
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }
    }
}