using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class Predmet
    {
        #region Properties
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        [NotMapped]
        public List<Materijal>? Materijali { get; set; }
        #endregion

        public Predmet() { }
    }
}
