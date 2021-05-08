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
        private int ID { get; set; }
        [Required]
        private string Naziv { get; set; }
        [Required]
        private string Opis { get; set; }
        [Required]
        [NotMapped]
        private List<Materijal>? Materijali { get; set; }
        #endregion

        public Predmet() { }
    }
}
