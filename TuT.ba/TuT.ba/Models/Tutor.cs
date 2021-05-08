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
        public string Slika { get; set; }
        public double ProsjecnaOcjena { get; set; }
        [Required]
        public NacinOdrzavanja DozvoljeniNacinRealizacije { get; set; }
        [Required]
        [NotMapped]
        public List<Tuple<Predmet,double>>? PredmetiSaCijenom { get; set; }
        #endregion

        public Tutor() { }
    }
}
