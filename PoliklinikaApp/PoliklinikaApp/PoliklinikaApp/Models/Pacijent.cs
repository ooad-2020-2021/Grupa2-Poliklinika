using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaApp.Models
{
    public class Pacijent : Korisnik
    {
        [Required]
        public int jmbg { get; set; }
        [Required]
        public MedicinskiKarton karton { get; set; }

        public Pacijent() { }

        public Pacijent(string i, string p, string s, string e):base(i,p,s,e)
        {
        }
        public void zakaziTermin(RasporedZaZakazivanje raspored) { }
    }
}
