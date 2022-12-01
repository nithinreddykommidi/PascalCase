using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.OOPS
{
    interface Iface1
    {
        void print1()
        {

        }
    }

    interface Iface2
    {
        void print2()
        {

        }
    }

    class Inter:Iface1,Iface2
    {
        public void print1()
        {
            Console.WriteLine("print1");
        }
        public void print2()
        {
            Console.WriteLine("print2");
        }
    }

    class p1
    {
        public static void Mainl()

        {
            Inter inter = new Inter();
            inter.print2();
            inter.print1();
        }
    }
}
