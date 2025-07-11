using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mariadb.Entities
{
    [Table("Korisnici")]
    public class Korisnik
    {
        [Key]
        public int IdKorisnika { get; set; }

        [Required]
        [MaxLength(50)]
        public string KorisnickoIme { get; set; } = string.Empty;

        [Required]
        public string Lozinka { get; set; } = string.Empty;

        public bool JeAdmin { get; set; } = false;

        [Required]
        public string ImePrezime { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        public ICollection<Rezervacija> Rezervacije { get; set; } = new HashSet<Rezervacija>();
    }
}