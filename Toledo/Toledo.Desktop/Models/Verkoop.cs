using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Toledo.Desktop.Models
{
    [Table("Verkopen")]
    class Verkoop
    {
        public int Id { get; set; }
        public virtual List<Artikel> Artikelen { get; set; } = new List<Artikel>();
        public DateTime VerkoopDatum { get; set; } = DateTime.Now;
    }
}
