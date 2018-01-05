using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        private int chanceOfBuying;
        private int randomNumber;
        private bool purchase = false;
        public int ChanceOfBuying
        {
            get { return chanceOfBuying; }
            set { chanceOfBuying = value; }
        }
        public bool Purchase
        {
            get { return purchase; }
            set { purchase = value; }
        }
        //constructor
        public Customer(Random rnd, int temperature)
        {  
            randomNumber = rnd.Next(1, 50);
        }
        //member methods
        public bool CheckForThirsty(Random rnd, Customer customer)
        {//TODO: FIX
            if (customer.randomNumber < 25) {
                return false;
            }
            else {
                return true;
            }
        }
        public void AccountForWeather(Weather weather)
        {
            
        }
        public void AccountForCost()
        {

        }
        public void AccountForIngredients()
        {

        }
        private bool CheckWillBuy()
        {
            if(chanceOfBuying > 50)
            {
                return true;
            }
            return false;
        }
    }
}
