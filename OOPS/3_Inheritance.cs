using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    internal class _3_Inheritance
    {
        public static void Main67()
        { 
            Vehicle vehicle = new Vehicle();
            Cars cars= new Cars();
            Bike bike = new Bike();
            Boat boat = new Boat();


            vehicle.Go();
            cars.Go();
            bike.Go();
            boat.Go();

        }
    }

    class Vehicle
    {
        int speed = 0;

        public void Go()
        {
            Console.WriteLine("Moving");
        }
    }
    // Bike is inhering from the Vehicle
    class Bike : Vehicle
    {
        public int Wheels = 2; 
    }
    class Cars : Vehicle
    {
        public int Wheels = 4;
    }

    class Boat : Vehicle
    {
        public int Wheels = 2;
    }
}
