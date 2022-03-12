using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class AttorneysSlider
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
