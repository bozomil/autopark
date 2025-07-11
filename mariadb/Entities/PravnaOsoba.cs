using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mariadb.Entities
{
    [Table("PravnaOsoba")]
    public class PravnaOsoba
    {
        [Key]
        public int IdPravnaOsoba { get; set; }

        [Required]
        [MaxLength(255)]
        public string Naziv { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Adresa { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Mjesto { get; set; } = string.Empty;
    }

}