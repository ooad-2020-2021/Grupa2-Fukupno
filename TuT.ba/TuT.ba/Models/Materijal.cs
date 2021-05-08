using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public class Materijal
    {
        #region Properties
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string URL { get; set; }
        #endregion
        public Materijal() { }
    }
}
