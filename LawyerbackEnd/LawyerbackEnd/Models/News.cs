using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        public string Dates { get; set; }
        public string ButtonOnetext { get; set; }
        public string ButtonOneLink { get; set; }
        public string ButtonTwotext { get; set; }
        public string ButtonTwoLink { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
