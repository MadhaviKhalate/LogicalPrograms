﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public void perfect_Number()
        {
            int sum = 0, number;
            Console.WriteLine("Enter Number to check wheather it is perfect or not");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }  
            }
            if (sum == number)
            {
                Console.WriteLine("{0} is a Perfect number", number);
            }
            else
            {
                Console.WriteLine("{0} isn't a Perfect number", number);
            }
        }
    }
}
