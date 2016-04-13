using System.Data.Entity;
using Toledo.Desktop.Models;

namespace Toledo.Desktop.Data
{
    class ToledoDb : DbContext
    {
        public ToledoDb() : base("Toledo")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ToledoDb>());
        }

        public DbSet<Artikel> Artikelen { get; set; }
        public DbSet<Verkoop> Verkopen { get; set; }
        public DbSet<Categorie> Categorieen { get; set; }
    }
}
