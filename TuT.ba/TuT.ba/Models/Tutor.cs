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
        #region Properties
        [Required]
        private string Slika { get; set; }
        
        private double ProsjecnaOcjena { get; set; }
        [Required]
        private NacinOdrzavanja DozvoljeniNacinRealizacije { get; set; }
        [Required]
        [NotMapped]
        private List<Tuple<Predmet,double>>? PredmetiSaCijenom { get; set; }
        #endregion
    }
}
