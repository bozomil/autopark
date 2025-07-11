using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mariadb.Entities
{
    [Table("Proizvodjaci")]
    public class Proizvodjac
    {
        [Key]
        public int IdProizvodjac { get; set; }

        [Required]
        [MaxLength(100)]
        public string NazivProizvodjaca { get; set; } = string.Empty;

        public ICollection<Automobil> Automobili { get; set; } = new HashSet<Automobil>();
    }
}