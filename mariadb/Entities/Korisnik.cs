using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mariadb.Entities
{
    [Table("Korisnici")]
    public class Korisnik
    {
        [Key]
        public int IdKorisnika { get; set; }

        [Required]
        [StringLength(50)]
        public string KorisnickoIme { get; set; }

        [Required]
        [StringLength(100)]
        public string Lozinka { get; set; }

        [Required]
        public bool JeAdmin { get; set; }

        [Required]
        [StringLength(100)]
        public string ImePrezime { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public virtual ICollection<Rezervacija> Rezervacije { get; set; }
    }
}