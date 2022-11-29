using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    internal class _2_ConstructorOverloading
    {// We can create different constructors for different arguments
        public static void Main12()
        {
            Pizza P1 = new Pizza("garlic bread", "Cheese", "chicken", "mustard");
            Pizza P2 = new Pizza("garlic bread", "Cheese", "chicken");
            Pizza P3 = new Pizza("garlic bread", "Cheese");
            Pizza P4 = new Pizza("garlic bread");
        }
    }

    class Pizza
    {
        string bread;
        string cheese;
        string toppings;
        string suace;

        public Pizza(string bread, string cheese, string toppings, string suace)
        {
            this.bread = bread;
            this.cheese = cheese;
            this.toppings = toppings;
            this.suace = suace;
            Console.WriteLine("your pizza contains all 4 customizations");
        }
        public Pizza(string bread, string cheese, string toppings)
        {
            this.bread = bread;
            this.cheese = cheese;
            this.toppings = toppings;
            Console.WriteLine("your pizza contains 3 customizations");
        }
        public Pizza(string bread, string cheese)
        {
            this.bread = bread;
            this.cheese = cheese;
            //this.toppings = toppings;
            Console.WriteLine("your pizza contains 2 customizations");
        }
        public Pizza(string bread)
        {
            this.bread = bread;
            Console.WriteLine("your pizza contains only bread");
        }
    }
}   


