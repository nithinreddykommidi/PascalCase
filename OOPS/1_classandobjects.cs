using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    internal class _1_classandobjects
    {
        public static void Mainm() 
        {// For Creating  the object of a class
            Car car1 = new Car("Ford","Mustang",2000,"Red");
            Car car2 = new Car("Ford", "Beetle", 2020, "Yellow");

            car1.Drive();
            car2.Drive();

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


        public Car(string make,string model, int year, string color) 
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            TotalCars++;
        }

        public void Drive()
        {
            Console.WriteLine("You are driving {0} {1} {2} {3}",make,model,year,color);
        }


    }
}
