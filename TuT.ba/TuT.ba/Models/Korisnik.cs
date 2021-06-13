using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace TuT.ba.Models
{
    public abstract class Korisnik
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [DisplayName("Korisničko ime:")]
        public string KorisnickoIme { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum rođenja:")]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        [RegularExpression(@"/(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}", 
            ErrorMessage = "Sifra mora da sadrži bar jedno malo slovo, jedno veliko slovo i jedan broj, te da bude duža od 8 karaktera")]
        [DisplayName("Šifra:")]
        [DataType(DataType.Password)]
        public string Sifra { get; set; }
        [Required]
        [RegularExpression(@"^[a-z]{1,}\d{1,}@etf.unsa.ba$", ErrorMessage = "Mora biti ETF mail")]
        public string Email { get; set; }
        [DisplayName("Bankovni račun:")]
        public BankovniRacun BankovniRacun { get; set; }
        #endregion

        public Korisnik() { }

    }
}
