using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class Materijal
    {
        [Key]
        [Required]
        private int ID { get; set; }
        [Required]
        private string URL { get; set; }

    }
}
