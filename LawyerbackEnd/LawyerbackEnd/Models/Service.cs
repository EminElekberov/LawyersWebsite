﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Buttontext { get; set; }
        [Required]
        public string ButtonLink { get; set; }
    }
}
