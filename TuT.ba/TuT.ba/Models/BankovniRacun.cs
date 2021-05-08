using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class BankovniRacun
    {
        [Required]
        [Key]
        private int ID { get; set; }
        [Required]
        private long BrojRacuna { get; set; }
        [Required]
        private double StanjeRacuna { get; set; }
        [Required]
        [RegularExpression(@"^\d{3}-\d{3}$", ErrorMessage ="Format CSC-a mora biti xxx-xxx")]
        private int CSC { get; set; }
        [Required]
        private DateTime DatumIsteka { get; set; }

    }
}
