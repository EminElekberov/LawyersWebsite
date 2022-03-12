using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class OurAbout
    {
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string headerUndeer { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Dates { get; set; }
        [Required]
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
    }
}
