using System.ComponentModel.DataAnnotations;

namespace PoliklinikaApp.Models
{
    public class Nalaz
    {
        [Key]
        [Required]
        public int id_nalaza { get; set; }
        [Required]
        public MedicinskiKarton karton{ get; set; }
        [Required]
        public string misljenje { set; get; }
        [Required]
        public string statusPacijenta { set; get; }

        public void ispuniKarton(MedicinskiKarton karton) {
            this.karton = karton;
        }
    }
}