using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class PracticeAbout
    {
        public int Id { get; set; }
        [Required]
        public string IconLink { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Learntext { get; set; }
        [Required]
        public string LearnLink { get; set; }
    }
}
