using System;

namespace ZombiSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Player 
    {
        public Inventory Inventory {get; set;}
        public Primary Primary {get; set; }
        public Secondary Secondary {get; set;}
        public Health CurrentHealth {get; set;}
    }
    class Inventory 
    {
        public int InventoryCapacity { get; set; }
        public list<Items> CurrentInventory { get; set; }
    }
    class Items 
    {
        public string Name { get; set; }
        public int Weight { get; set; }
    }
    class Zombie 
    {
        public Inventory Inventory {get; set;}
        public Health CurrentHealth {get; set;}

        public EatPlayer() 
        {
            
        }
    }
}
