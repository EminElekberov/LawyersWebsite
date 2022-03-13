using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Biography
    {
        public int Id { get; set; }
        public string BioHeader { get; set; }
        [Required]
        public string BioDescription { get; set; }
        public string EducationHeader { get; set; }
        [Required]
        public string EducationDescription { get; set; }
        public string Aphorizm { get; set; }
        public string AwarsHeader { get; set; }
        [Required]
        public string AwardDescription { get; set; }
        public string AwardIconsDesc { get; set; }
        public string Job { get; set; }
        public string Name { get; set; }
        public string Comminucate { get; set; }
        public string IconsComminucate { get; set; }
        public string IconsComminucate2 { get; set; }
        public string IconsComminucate3 { get; set; }
        public string PractiseHeader { get; set; }
        public string PrcatiseDesc { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo{ get; set; }
    }
}
