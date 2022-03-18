using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Challenge { get; set; }
        public string Solution { get; set; }
        public string Result { get; set; }
        public int Time { get; set; }
        public string LawherFullname { get; set; }
        public int Price { get; set; }
        public Categorys categorys { get; set; }
        public int categorysId { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        
    }
}
