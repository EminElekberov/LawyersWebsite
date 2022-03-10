using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class IndexChoose
    {
        public int Id { get; set; }
        [Required]
        public string Textone { get; set; }
        [Required]
        public string TextTwo { get; set; }
        [Required]
        public string numberOne { get; set; }
        [Required]
        public string numberTwo { get; set; }
        [Required]
        public string numberThree { get; set; }
        [Required]
        public string numberFour { get; set; }
        [Required]
        public string numbroneDesc { get; set; }
        [Required]
        public string numbrTWoDesc { get; set; }
        [Required]
        public string numbrThreeDesc { get; set; }
        [Required]
        public string numbFourDesc { get; set; }

    }
}
