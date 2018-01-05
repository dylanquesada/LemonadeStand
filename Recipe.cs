using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        // member variables
        private int cupsNeeded;
        private int lemonsNeeded;
        private int sugarUnitsNeeded;
        private int iceCubesNeeded;
        
        //accessor for member variables
        public int CupsNeeded
        {
            get { return cupsNeeded; }
            set { cupsNeeded = value; }
        }
        public int LemonsNeeded
        {
            get { return lemonsNeeded; }
            set { lemonsNeeded = value; }
        }
        public int SugarUnitsNeeded
        {
            get { return sugarUnitsNeeded; }
            set { sugarUnitsNeeded = value; }
        }
        public int IceCubesNeeded
        {
            get { return iceCubesNeeded; }
            set { iceCubesNeeded = value; }
        }
        // constructor
        public Recipe()
        {

        }
        // member methods
    }
}
