using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mariadb.Entities
{
    [Table("Proizvodjaci")]
    public class Proizvodjac
    {
        [Key]
        public int IdProizvodjac { get; set; }

        [Required]
        [StringLength(100)]
        public string NazivProizvodjaca { get; set; }

        public virtual ICollection<Automobil> Automobili { get; set; }
    }
}