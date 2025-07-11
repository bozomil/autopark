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

        [Required]
        public int IdKorisnika { get; set; }

        [Required]
        [StringLength(20)]
        public string Registracija { get; set; }

        [Required]
        public DateTime DatumOdlaska { get; set; }

        [Required]
        public DateTime DatumDolaska { get; set; }

        [Required]
        [StringLength(100)]
        public string Mjesto { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Udaljenost { get; set; }

        public string RazlogOpis { get; set; }

        [Required]
        public bool Odobreno { get; set; } = false;

        [ForeignKey("IdKorisnika")]
        public virtual Korisnik Korisnik { get; set; }

        [ForeignKey("Registracija")]
        public virtual Automobil Automobil { get; set; }
    }
}