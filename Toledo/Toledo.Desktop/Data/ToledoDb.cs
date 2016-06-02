using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using Toledo.Desktop.Migrations;
using Toledo.Desktop.Models;

namespace Toledo.Desktop.Data
{
    class ToledoDb : DbContext
    {
        public ToledoDb(string connection) : base(connection)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ToledoDb, Configuration>());
        }

        public ToledoDb() : this(Program.Settings.ConnectionString)
        {
        }

        public DbSet<Artikel> Artikelen { get; set; }
        public DbSet<Verkoop> Verkopen { get; set; }
        public DbSet<Categorie> Categorieen { get; set; }
    }
}
