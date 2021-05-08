using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class Instrukcija
    {
        #region Properties
        [Key]
        [Required]
        private int ID { get; set; }
        [Required]
        private Student Student { get; set; }
        [Required]
        private Tutor Tutor { get; set; }
        [Required]
        [DataType(DataType.Date)]
        private DateTime DatumOdrzavanja { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage ="Trajanje ne smije biti negativno!")]
        private int Trajanje { get; set; }
        [Required]
        [EnumDataType(typeof(NacinOdrzavanja))]
        private NacinOdrzavanja NacinOdrzavanja { get; set; }
        [Required]
        private double Cijena { get; set; }
        [Required]
        private double? Popust { get; set; }
        #endregion

        public Instrukcija() { }
    }
}
