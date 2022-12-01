using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    interface I1
    {
        void InterfaceMethod();

    }

    interface I2
    {
        void InterfaceMethod();
    }

    /* 
     Explicit Interface is when we have two interfaces with same method name
     we need to explicitly mention the interface name befor method
     we cannot use acces modifiers for that method implimentation
    eg: <interfacename>.<methodname>
    */
    class Explicit : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("i1");
        } 
        void I2.InterfaceMethod()
        {
            Console.WriteLine("i2");
        }

    }

    class Explicit1
    {
        public static void Main12()
        {
            Explicit e = new Explicit();
            /*
             * We have to typecast the object to interface to for using interface method
             */
            ((I1)e).InterfaceMethod(); 
            ((I2)e).InterfaceMethod();

            /* 
             Or we can create an Interface object 
             */

            I1 a1 = new Explicit();
            I2 a2 = new Explicit();

            a1.InterfaceMethod();
            a2.InterfaceMethod();
        }

    }

}
