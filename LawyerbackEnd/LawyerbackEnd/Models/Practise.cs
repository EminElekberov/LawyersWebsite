using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Practise
    {
        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
