using System.ComponentModel.DataAnnotations;

namespace PoliklinikaApp.Models
{
    public class Recept
    {
        [Required]
        public string medUstanova;
        [Required]
        public string recept;
        [Required]
        public int sifraLijeka;
        [Required]
        public string farmaceut;
        [Key]
        [Required]
        public int kodZaRecept;

        public void ispuniPodatke(string ustanova, string recept, int lijek, string ph, int kodRecepta) {
            medUstanova = ustanova;
            this.recept = recept;
            sifraLijeka = lijek;
            farmaceut = ph;
            kodZaRecept = kodRecepta;
        }
    }
}