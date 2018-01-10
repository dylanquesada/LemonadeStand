using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class IceCube : Item
    {
        // member variables
        public string Name
        {
            get { return name; }
        }
        public decimal Cost
        {
            get { return cost; }
        }
        // constructor
        public IceCube()
        {
            name = "ice cube";
            cost = .01m;
        }
        // member methods
    }
}
