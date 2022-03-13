using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class AttorneyWork
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Buttontext { get; set; }
        public string ButtonLink { get; set; }
    }
}
