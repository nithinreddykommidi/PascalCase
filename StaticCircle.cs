using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class StaticCircle
    {
        public static float PI = 3.147F;
        public int radius;
        public  StaticCircle(int r)
        {
            r = radius;
            Console.WriteLine(r);
        }
        public float Area()
        {
            float a = StaticCircle.PI * radius * radius;
            return a;
        }
    }

}
