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

        private int lemonsNeeded;
        private int sugarUnitsNeeded;
        private int iceCubesNeeded;
        
        //accessor for member variables

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
            LemonsNeeded = 1;
            SugarUnitsNeeded = 10;
            IceCubesNeeded = 1;
        }
        // member methods

    }
}
