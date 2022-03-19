using LawyerbackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.ViewModel
{
    public class PacketVm
    {
        public int PacketID { get; set; }
        public List<int> ComponentsId { get; set; }
    }
}
