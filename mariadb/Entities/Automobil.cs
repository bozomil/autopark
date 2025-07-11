using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mariadb.Entities
{
    [Table("Automobili")]
    public class Automobil
    {
        [Key]
        public int IdAutomobila { get; set; }

        [Required]
        [MaxLength(10)]
        public string Registracija { get; set; } = string.Empty;

        [ForeignKey(nameof(Proizvodjac))]
        public int IdProizvodjac { get; set; }
        public Proizvodjac Proizvodjac { get; set; } = null!;

        [ForeignKey(nameof(Gorivo))]
        public int IdGoriva { get; set; }
        public Gorivo Gorivo { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateTime DatumRegistracije { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; } = string.Empty;

        public int GodinaProizvodnje { get; set; }

        public int? ccm { get; set; }

        public int? kW { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal? Potrosnja { get; set; }

        public bool Dostupan { get; set; } = true;

        [Column(TypeName = "decimal(10,2)")]
        public decimal KilometriNaRegistraciji { get; set; } = 0;

        public ICollection<Rezervacija> Rezervacije { get; set; } = new HashSet<Rezervacija>();
        public ICollection<Servis> Servisi { get; set; } = new HashSet<Servis>();
    }
}