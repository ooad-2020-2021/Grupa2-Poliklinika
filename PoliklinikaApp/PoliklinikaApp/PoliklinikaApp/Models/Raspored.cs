using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaApp.Models
{
    public class Raspored
    {
        [Required]
        [NotMapped]
        public List<DateTime> datumi { get; set; }
        [Required]
        public DateTime vrijeme { get; set; }
    }
}
