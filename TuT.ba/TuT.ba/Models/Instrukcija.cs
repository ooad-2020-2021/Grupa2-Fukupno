using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class Instrukcija
    {
        [Key]
        [Required]
        private int ID { get; set; }
        [Required]
        private Student student { get; set; }
        [Required]
        private Tutor tutor { get; set; }
        [Required]
        private DateTime datumOdrzavanja { get; set; }
        [Required]
        private int trajanje { get; set; }
        [Required]
        private NacinOdrzavanja nacinOdrzavanja { get; set; }
        [Required]
        private double cijena { get; set; }
        [Required]
        private double? popust { get; set; }
    }
}
