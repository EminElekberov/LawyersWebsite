using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class PacketToComponents
    {
        public int PacketId { get; set; }
        public int componentsId { get; set; }
        public Components components { get; set; }
        public Packet packet { get; set; }
    }
}
