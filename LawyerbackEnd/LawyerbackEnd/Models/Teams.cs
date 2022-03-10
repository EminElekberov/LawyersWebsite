using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string SocialNetworkLink { get; set; }
        public string SocialNetworkLink2 { get; set; }
        public string SocialNetworkLink3{ get; set; }
        public string SocialNetworkLink4 { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
