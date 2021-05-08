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
        private Student Student { get; set; }
        [Required]
        private Tutor Tutor { get; set; }
        [Required]
        private DateTime DatumOdrzavanja { get; set; }
        [Required]
        private int Trajanje { get; set; }
        [Required]
        private NacinOdrzavanja NacinOdrzavanja { get; set; }
        [Required]
        private double Cijena { get; set; }
        [Required]
        private double? Popust { get; set; }
    }
}
