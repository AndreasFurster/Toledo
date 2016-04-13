using System.ComponentModel.DataAnnotations.Schema;

namespace Toledo.Desktop.Models
{
    [Table("Categorieen")]
    class Categorie
    {
        public Categorie() { }

        public Categorie(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
