using LawyerbackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.ViewModel
{
    public class PacketVm
    {
        public List<Components> Components { get; set; }
        public List<Packet> Packets { get; set; }
        public int PacketID { get; set; }
        public List<int> ComponentsId { get; set; }
    }
}
