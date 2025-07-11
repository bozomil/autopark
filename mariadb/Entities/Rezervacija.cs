using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mariadb.Entities
{
    [Table("Rezervacije")]
    public class Rezervacija
    {
        [Key]
        public int IdRezervacije { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int IdKorisnika { get; set; }
        public Korisnik Korisnik { get; set; } = null!;

        [ForeignKey(nameof(Automobil))]
        public int IdAutomobila { get; set; }
        public Automobil Automobil { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateTime DatumOdlaska { get; set; }

        [Column(TypeName = "date")]
        public DateTime DatumDolaska { get; set; }

        [Required]
        [MaxLength(100)]
        public string Mjesto { get; set; } = string.Empty;

        [Column(TypeName = "decimal(8,2)")]
        public decimal Udaljenost { get; set; }

        public string? RazlogOpis { get; set; }

        public bool Odobreno { get; set; } = false;
    }
}