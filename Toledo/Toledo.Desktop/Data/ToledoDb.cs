using System;
using System.Data.Entity;
using Toledo.Desktop.Models;

namespace Toledo.Desktop.Data
{
    class ToledoDb : DbContext
    {
        public ToledoDb(string connection) : base(connection)
        {
        }

        public ToledoDb() : base(Program.Settings.ConnectionString)
        {
           // Database.SetInitializer(new CreateDatabaseIfNotExists<ToledoDb>());
        }

        public DbSet<Artikel> Artikelen { get; set; }
        public DbSet<Verkoop> Verkopen { get; set; }
        public DbSet<Categorie> Categorieen { get; set; }
    }
}
