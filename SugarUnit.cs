﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class SugarUnit : Item
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
        public SugarUnit()
        {
            name = "sugar unit";
            cost = .05m;
        }
        // member methods
    }
}
