using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class SquartRoot
    {
        public static void root(int c)
        {
            double t;
            t = c;
            while (Math.Abs(t - c / t) > ((1e-15) * t))
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine("Square root of " + c + " is: " + t);
        }
    }
}
