using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        private decimal money;
        private string name;
        //constructor
        public Player()
        {

        }
        //member methods
        public void BuyCups()
        {
            //money -= 
        }
        public decimal GiveMoney(decimal moneySpent, decimal money)
        {
            return money - moneySpent;
        }
    }
}
