using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public abstract class Korisnik
    {
        [Required]
        [Key]
        private int ID { get; set; }
        [Required]
        private string ime { get; set; }
        [Required]
        private string prezime { get; set; }
        [Required]
        private string korisnickoIme { get; set; }
        [Required]
        private DateTime datumRodjenja { get; set; }
        [Required]
        [RegularExpression(@"/(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}", 
            ErrorMessage = "Sifra mora da sadrži bar jedno malo slovo, jedno veliko slovo i jedan broj, te da bude duža od 8 karaktera")]
        private string sifra { get; set; }
        [Required]
        [RegularExpression(@"^[a-z]{1,}\d{1,}@etf.unsa.ba$", ErrorMessage = "Mora biti ETF mail")]
        private string email { get; set; }
        [Required]
        private BankovniRacun bankovniRacun { get; set; }


    }
}
