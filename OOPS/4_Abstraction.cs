using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    internal class _4_Abstraction
    {// we cannot create objects for an abstract method but we can create objects of derived class
        // To create abstract methods class must be abstract
        public static void Maino()
        {
            //Vehicles vehicle = new Vehicles();
            //creating object for vehicle gives an exception  


            Caars cars = new Caars();
            Bikes bike = new Bikes();
            Boats boat = new Boats();


            //vehicle.Move();
            cars.Move();
            bike.Move();
            boat.Move();

        }
    }

     abstract class Vehicles
    {
        int speed = 0;

        public void Move()
        {
            Console.WriteLine("Moving");
        }
    }
    // Bike is inhering from the Vehicle
    class Bikes : Vehicles
    {
        public int Wheels = 2;
    }
    class Caars : Vehicles
    {
        public int Wheels = 4;
    }

    class Boats : Vehicles
    {
        public int Wheels = 2;
    }
}
