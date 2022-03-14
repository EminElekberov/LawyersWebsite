using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string AddressHeader { get; set; }
        public string Address { get; set; }
        public string PhoneHeader { get; set; }
        public string Phone { get; set; }
        public string OfficeHeader { get; set; }
        public string Hours { get; set; }
        public string ContactHeader { get; set; }
        public string ContactHeaderDescription { get; set; }
    }
}
