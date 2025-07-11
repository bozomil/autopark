using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mariadb.Entities
{
    [Table("PravnaOsoba")]
    public class PravnaOsoba
    {
        [Key]
        public int IdPravnaOsoba { get; set; }

        [Required]
        [StringLength(255)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(255)]
        public string Adresa { get; set; }

        [Required]
        [StringLength(100)]
        public string Mjesto { get; set; }
    }
}