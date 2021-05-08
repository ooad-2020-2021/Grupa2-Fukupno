using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuT.ba.Models
{
    public abstract class Korisnik
    {
        #region Properties
        [Required]
        [Key]
        private int ID { get; set; }
        [Required]
        private string Ime { get; set; }
        [Required]
        private string Prezime { get; set; }
        [Required]
        private string KorisnickoIme { get; set; }
        [Required]
        [DataType(DataType.Date)]
        private DateTime DatumRodjenja { get; set; }
        [Required]
        [RegularExpression(@"/(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}", 
            ErrorMessage = "Sifra mora da sadrži bar jedno malo slovo, jedno veliko slovo i jedan broj, te da bude duža od 8 karaktera")]
        private string Sifra { get; set; }
        [Required]
        [RegularExpression(@"^[a-z]{1,}\d{1,}@etf.unsa.ba$", ErrorMessage = "Mora biti ETF mail")]
        private string Email { get; set; }
        [Required]
        private BankovniRacun BankovniRacun { get; set; }
        #endregion


        public Korisnik() { }

    }
}
