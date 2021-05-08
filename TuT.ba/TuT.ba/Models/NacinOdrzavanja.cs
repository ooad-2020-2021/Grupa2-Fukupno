using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class NacinOdrzavanja
    {
        public enum NacinOdrzavanjaEnum{
            [Display(Name = "Online")]
            Online,
            [Display(Name = "Uzivo")]
            Uzivo,
            [Display(Name = "Uzivo/Online")]
            UzivoOnline
        }

        [Key]
        [Required]
        public NacinOdrzavanjaEnum nacinOdrzavanja { get; set; }    

    }
}
