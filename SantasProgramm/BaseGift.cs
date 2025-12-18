using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasProgramm
{
    public abstract class BaseGift
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public BaseGift(string name, string description, int weight)
        {
            Name = name;
            Description = description;
            Weight = weight;
        }
    }
}
