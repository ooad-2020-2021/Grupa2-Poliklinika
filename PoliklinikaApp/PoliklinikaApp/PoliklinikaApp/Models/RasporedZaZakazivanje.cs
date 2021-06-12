using System;

namespace PoliklinikaApp.Models
{
    public class RasporedZaZakazivanje:Raspored
    {
        //public DateTime termin;

        public bool zakaziTermin(DateTime t) {
            //Dok ne implementiramo metodu stavljamo da je true defaultno 
            return true;
        }

        public bool otkaziTermin(DateTime t) {
            //Dok ne implementiramo metodu stavljamo da je true defaultno 
            return true;
        }

        public bool promijeniTermin(DateTime t) {
            //Dok ne implementiramo metodu stavljamo da je true defaultno 
            return true;
        }
    }
}