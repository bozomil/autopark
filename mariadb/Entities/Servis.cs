using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mariadb.Entities
{
    [Table("Servisi")]
    public class Servis
    {
        [Key]
        public int IdServisa { get; set; }

        [ForeignKey(nameof(Automobil))]
        public int IdAutomobila { get; set; }
        public Automobil Automobil { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateTime DatumServisa { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal CijenaServisa { get; set; }

        [MaxLength(255)]
        public string? OpisServisa { get; set; }
    }
}