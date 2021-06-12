namespace PoliklinikaApp.Models
{
    public class RasporedPregleda:Raspored
    {
        public bool zakazanTermin { get; set; }
        public bool slobodanTermin { get; set; }
        public bool otkazanTermin { get; set; }

        public bool postaviStatusTermina(int status) {
            if (status == 0)
            {
                zakazanTermin = true;
                slobodanTermin = otkazanTermin = false;
            }
            else if (status == 1)
            {
                slobodanTermin = true;
                zakazanTermin = otkazanTermin = false;
            }
            else {
                otkazanTermin = true;
                zakazanTermin = slobodanTermin = false;
            }
            return true;
        }
    }
}