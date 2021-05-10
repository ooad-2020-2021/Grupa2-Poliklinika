using System.ComponentModel.DataAnnotations;

namespace PoliklinikaApp.Models
{
    public class Nalaz
    {
        [Required]
        public MedicinskiKarton karton;
        [Required]
        public string misljenje { set; get; }
        [Required]
        public string statusPacijenta { set; get; }
        public void ispuniKarton(MedicinskiKarton karton) {
            this.karton = karton;
        }
    }
}