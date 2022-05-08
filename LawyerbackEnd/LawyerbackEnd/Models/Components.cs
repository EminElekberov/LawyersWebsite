using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Components
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<PacketToComponents> PacketToComponents { get; set; }
    }
}
