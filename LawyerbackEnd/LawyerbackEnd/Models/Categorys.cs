using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class Categorys
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string className { get; set; }
        public List<Case> Cases { get; set; }

    }
}
