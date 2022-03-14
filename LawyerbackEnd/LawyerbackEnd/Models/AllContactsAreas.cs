using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class AllContactsAreas
    {
        public int Id { get; set; }
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
