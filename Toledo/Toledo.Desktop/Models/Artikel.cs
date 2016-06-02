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
        public decimal PrijsInclBtw  { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}
