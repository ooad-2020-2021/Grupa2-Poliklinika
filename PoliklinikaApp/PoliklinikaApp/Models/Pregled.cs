using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaApp.Models
{
    public class Pregled
    {
        [Required]
        public Doktor doktor;
        [Required]
        public Pacijent pacijent;
        [Required]
        public DateTime datum;

        public void ispuniMedKarton(MedicinskiKarton karton) { }
        public void ispuniNalaz(Nalaz nalaz) { }
        public void ispuniRecept(Recept recept) { }
    }
}
