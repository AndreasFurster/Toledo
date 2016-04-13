using System.ComponentModel.DataAnnotations.Schema;

namespace Toledo.Desktop.Models
{
    [Table("Artikelen")]
    class Artikel
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Omschrijving { get; set; }
        public BtwTarief BtwTarief { get; set; } = BtwTarief.Btw21;
        public decimal? StandaardPrijsInclBtw  { get; set; }
        public decimal? KortingsPrijsInclBtw { get; set; }
        public virtual Categorie Categorie { get; set; }
        public bool Leverbaar { get; set; } = true;

        [NotMapped]
        public decimal Prijs {
            get {
                return KortingsPrijsInclBtw ?? (StandaardPrijsInclBtw != null ? StandaardPrijsInclBtw.Value : 0m); 
            }
        }
    }
}
