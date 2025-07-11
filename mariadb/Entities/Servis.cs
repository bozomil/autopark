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

        [Required]
        [StringLength(20)]
        public string Registracija { get; set; }

        [Required]
        public DateTime DatumServisa { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        public decimal CijenaServisa { get; set; }

        [StringLength(255)]
        public string OpisServisa { get; set; }

        [ForeignKey("Registracija")]
        public virtual Automobil Automobil { get; set; }
    }
}