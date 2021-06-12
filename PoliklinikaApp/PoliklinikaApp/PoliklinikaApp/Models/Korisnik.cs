using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaApp.Models
{
    public class Korisnik
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 10,ErrorMessage ="Vaše ime bi trebalo imati najviše 10 znakova")]
        public string ime { get; set; }
        [Required]
        [StringLength(maximumLength: 20,ErrorMessage ="Vaše prezime bi trebalo imati najviše 20 znakova")]
        public string prezime { get; set; }
        [Required]
        public string sifra { get; set; }
        [Required]
        public string email { get; set; }

        public Korisnik() { }
        public Korisnik(string i, string p, string s, string e) {
            ime = i;
            prezime = p;
            sifra = s;
            email = e;
        }
    }
}
