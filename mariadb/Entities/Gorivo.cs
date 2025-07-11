using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mariadb.Entities
{
    [Table("Goriva")]
    public class Gorivo
    {
        [Key]
        public int IdGoriva { get; set; }

        [Required]
        [MaxLength(50)]
        public string NazivGoriva { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal CijenaGoriva { get; set; }

        public ICollection<Automobil> Automobili { get; set; } = new HashSet<Automobil>();
    }
}