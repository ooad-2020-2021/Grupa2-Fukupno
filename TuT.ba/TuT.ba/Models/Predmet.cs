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
        [Key]
        [Required]
        private int ID { get; set; }
        [Required]
        private string naziv { get; set; }
        [Required]
        private string opis { get; set; }
        [Required]
        [NotMapped]
        private List<Materijal>? materijali { get; set; }

    }
}
