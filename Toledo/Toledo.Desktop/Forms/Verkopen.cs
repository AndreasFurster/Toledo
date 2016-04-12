using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Toledo.Desktop.Data;
using Toledo.Desktop.Models;

namespace Toledo.Desktop.Forms
{
    public partial class Verkopen : CustomMetroForm
    {
        private readonly Verkoop verkoop = new Verkoop();

        public Verkopen()
        {
            InitializeComponent();
            ListenForBarcodes();

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

                verkoop.Artikelen.Add(artikel);
                db.Verkopen.AddOrUpdate(verkoop);
                var task = db.SaveChangesAsync();
                ReloadGrid();
                task.Wait();
            }
        }

        private void ReloadGrid()
        {
            var artikelen = verkoop.Artikelen.GroupBy(a => a.Barcode);
            foreach (var artikelgroep in artikelen)
            {
                var row = new
                {
                    barcode = artikelgroep.First().Barcode,
                    aantal = artikelgroep.Count(),
                    beschrijving = artikelgroep.First().Omschrijving,
                    prijsPerStuk = artikelgroep.First().KortingsPrijsInclBtw ?? artikelgroep.First().StandaardPrijsInclBtw,
                    prijsTotaal = artikelgroep.Sum(a => a.KortingsPrijsInclBtw ?? a.StandaardPrijsInclBtw)
                };

                verkopenGrid.Rows.Add(row);
            }
        }

        private void Verkopen_Load(object sender, EventArgs e)
        {
        }
    }
}