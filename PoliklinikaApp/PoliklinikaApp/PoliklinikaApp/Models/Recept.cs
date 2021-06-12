using System.ComponentModel.DataAnnotations;

namespace PoliklinikaApp.Models
{
    public class Recept
    {
        [Key]
        [Required]
        public int kodZaRecept { get; set; }

        [Required]
        public string medUstanova { get; set; }
        [Required]
        public string recept { get; set; }
        [Required]
        public int sifraLijeka { get; set; }
        [Required]
        public string farmaceut { get; set; }

        public void ispuniPodatke(string ustanova, string recept, int lijek, string ph, int kodRecepta) {
            medUstanova = ustanova;
            this.recept = recept;
            sifraLijeka = lijek;
            farmaceut = ph;
            kodZaRecept = kodRecepta;
        }
    }
}