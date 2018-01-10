using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cup : Item
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
        public Cup()
        {
            name = "cup";
            cost = .5m;
        }
        // member methods
    }
}
