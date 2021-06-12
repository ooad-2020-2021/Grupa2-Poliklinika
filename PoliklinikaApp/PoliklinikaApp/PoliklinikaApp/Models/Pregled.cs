using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaApp.Models
{
    public class Pregled
    {
        [Key]
        [Required]
        public int id_pregleda {get; set;}
        [Required]
        public Doktor doktor { get; set;}
        [Required]
        public Pacijent pacijent { get; set;}
        [Required]
        public DateTime datum { get; set;}

        public void ispuniMedKarton(MedicinskiKarton karton) { }
        public void ispuniNalaz(Nalaz nalaz) { }
        public void ispuniRecept(Recept recept) { }
    }
}
