using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mariadb.Entities
{
    [Table("Goriva")]
    public class Gorivo
    {
        [Key]
        public int IdGoriva { get; set; }

        [Required]
        [StringLength(50)]
        public string NazivGoriva { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal CijenaGoriva { get; set; }

        public virtual ICollection<Automobil> Automobili { get; set; }
    }
}