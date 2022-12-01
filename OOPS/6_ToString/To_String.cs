using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS._6_ToString
{
    internal class To_String
    {
        public static void lMain()
        {// For Creating  the object of a class
            Car car1 = new Car("Ford", "Mustang", 2000, "Red");
            Car car2 = new Car("Ford", "Beetle", 2020, "Yellow");

            Console.WriteLine(car1);
            Console.WriteLine(car2);


            Console.WriteLine(Car.TotalCars);
        }

    }


    class Car
    {
        string make;
        string model;
        int year;
        string color;
        public static int TotalCars;// Static Variables and methods cannot be accesed by instances
        // We cannot Create objects for static classes eg: Math.Round();


        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            TotalCars++;
        }

        public override string ToString()
        {
            string Message = "You are driving " + make +" "+ model;
            return Message;
            //Console.WriteLine("You are driving {0} {1} {2} {3}", make, model, year, color);
        }


    }
}
