using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int ID { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        public Tutor Tutor { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumOdrzavanja { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage ="Trajanje ne smije biti negativno!")]
        public int Trajanje { get; set; }
        [Required]
        [EnumDataType(typeof(NacinOdrzavanja))]
        [DisplayName("Način održavanja:")]
        public NacinOdrzavanja NacinOdrzavanja { get; set; }
        [Required]
        public double Cijena { get; set; }
        [Required]
        public double? Popust { get; set; }
        #endregion

        public Instrukcija() { }
    }
}
