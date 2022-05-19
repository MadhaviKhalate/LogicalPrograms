using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public void primeCheck()
        {
            Console.WriteLine("Enter the number to check its prime or not : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            if (IsPrime)
            {
                Console.WriteLine($"{num} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime Number.");
            }
        }
    }
}
