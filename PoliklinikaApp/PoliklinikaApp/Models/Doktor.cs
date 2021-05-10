using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaApp.Models
{
    public class Doktor
    {
        [Required]
        public string odjel { get; set; }
        [Required]
        public int kodZaRecepte { get; set; }

        public void azurirajTermine(RasporedPregleda raspored) { }
        public bool izdajRecept(Recept recept) {
            //Dok ne implementiramo metodu stavljamo da je true defaultno 
            return true;
        }
        public bool izdajNalaz(Nalaz nalaz) {
            //Dok ne implementiramo metodu stavljamo da je true defaultno 
            return true;
        }
    }
}
