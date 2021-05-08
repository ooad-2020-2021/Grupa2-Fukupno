using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class Tutor:Korisnik
    {
        [Required]
        private string slika { get; set; }
        [Required]
        private double prosjecnaOcjena { get; set; }
        [Required]
        private NacinOdrzavanja dozvoljeniNacinRealizacije { get; set; }
        [Required]
        [NotMapped]
        private List<Tuple<Predmet,double>>? predmetiSaCijenom { get; set; }

    }
}
