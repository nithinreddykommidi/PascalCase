using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Params_
    {
        public static void Main55()
        {
            double Ammount = CheckOut(12.3,14.5);
            Console.WriteLine(Ammount);
        }
        static double CheckOut(params double[] prices)

        {
            double Total = 0;
            foreach (double price in prices)
            {
                Total += price;
            }
            return Total;
        }
    }
}
