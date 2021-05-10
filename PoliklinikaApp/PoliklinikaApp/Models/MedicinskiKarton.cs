using System;
using System.ComponentModel.DataAnnotations;

namespace PoliklinikaApp.Models
{
    public class MedicinskiKarton
    {
        [Required]
        [Key]
        public int brMedKartona;
        [Required]
        public string anamneza { get; set; }
        [Required]
        public string medUsluga { get; set; }
        [Required]
        public string dijagnoza { get; set; }
        [Required]
        public int redniBrojPregleda { get; set; }
        [Required]
        public DateTime datum { get; set; }

        public void azurirajMedKarton(int brMedKartona)
        {
            this.brMedKartona = brMedKartona;
        }
    }
}