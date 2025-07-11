using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mariadb.Entities
{
    [Table("Automobili")]
    public class Automobil
    {
        [Key]
        [StringLength(20)]
        public string Registracija { get; set; }

        [Required]
        public int IdProizvodjac { get; set; }

        [Required]
        public int IdGoriva { get; set; }

        [Required]
        public DateTime DatumRegistracije { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        public int GodinaProizvodnje { get; set; }
        public int? ccm { get; set; }
        public int? kW { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal? Potrosnja { get; set; }

        [Required]
        public bool Dostupan { get; set; } = true;

        [Column(TypeName = "decimal(10,1)")]
        public decimal KilometriNaRegistraciji { get; set; } = 0.0M;

        [ForeignKey("IdProizvodjac")]
        public virtual Proizvodjac Proizvodjac { get; set; }

        [ForeignKey("IdGoriva")]
        public virtual Gorivo Gorivo { get; set; }

        public virtual ICollection<Rezervacija> Rezervacije { get; set; }
        public virtual ICollection<Servis> Servisi { get; set; }
    }
}