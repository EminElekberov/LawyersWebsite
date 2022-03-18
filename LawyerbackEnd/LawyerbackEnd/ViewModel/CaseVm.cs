using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.ViewModel
{
    public class CaseVm
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Challenge { get; set; }
        public string Solution { get; set; }
        public string Result { get; set; }
        public int Time { get; set; }
        public string LawherFullname { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string className { get; set; }
        public int CategoryId { get; set; }

    }
}
