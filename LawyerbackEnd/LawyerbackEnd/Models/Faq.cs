using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Faq
    {
        public int id { get; set; }
        public string Questiontext1 { get; set; }
        public string Question1 { get; set; }
        public string Questiontext2 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string QuestionText3 { get; set; }
        public string QuestionText4 { get; set; }
        public string Question4 { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
