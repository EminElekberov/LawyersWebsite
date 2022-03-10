using LawyerbackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.ViewModel
{
    public class HomeVM
    {
        public List<Slider> sliders { get; set; }
        public List<Holder> holders { get; set; }
        public List<Practise> practises { get; set; }
        public List<IndexChoose> indexChooses { get; set; }
        public List<Teams> teams { get; set; }
        public List<Category> categories { get; set; }

    }
}
