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
        public virtual Components components { get; set; }
        public virtual Packet packet { get; set; }
    }
}
