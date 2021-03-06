﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        private string name;
        UserInterface userInterface;
        Inventory inventory;
        Recipe recipe;
        public Inventory Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }
        //constructor
        public Player()
        {
            userInterface = new UserInterface();
            inventory = new Inventory();
            recipe = new Recipe();
            SetUserName();
        }
        //member methods
        private void SetUserName()
        {
            Console.WriteLine("Enter name for player:");
            Name = userInterface.GetUserInput();
        }
        
        public void SellCup(decimal cupPrice)
        {
            Inventory.Money += cupPrice;
            Inventory.PreparedLemonade -= 1;
            Inventory.AlterInventory(-1, "cups");
        }
        

        public void MakeLemonade()
        {
            Inventory.PreparedLemonade += 10;
            Inventory.AlterInventory(-Recipe.LemonsNeeded, "lemons");
            Inventory.AlterInventory(-Recipe.IceCubesNeeded, "ice cubes");
            Inventory.AlterInventory(-Recipe.SugarUnitsNeeded, "sugar units");
        }
    }
}
