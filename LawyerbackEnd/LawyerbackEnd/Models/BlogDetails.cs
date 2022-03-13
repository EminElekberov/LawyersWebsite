using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class BlogDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dates { get; set; }
        public string Buttontext1 { get; set; }
        public string ButtonLink1 { get; set; }
        public string Buttontext2 { get; set; }
        public string ButtonLink2 { get; set; }
        public string Header { get; set; }
        public string headerDesc { get; set; }
        public string Title { get; set; }
        public string titleDesc { get; set; }
        public string Aphorizm { get; set; }
        public string AphirzmWriter { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string AboutDesc { get; set; }
        public string RecentTitle { get; set; }
        public string RecentDesc { get; set; }
        public string CateagoriesTitle { get; set; }
        public string CategoriesDesc { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
