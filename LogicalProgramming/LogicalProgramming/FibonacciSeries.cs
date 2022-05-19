using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {
        public void Fibonacci_Series()
        {
            Console.WriteLine("Enter the number of elements to print fabonacci series : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int firstNum = 0, secondNum = 1, nextNum = 0;
            Console.Write(firstNum + " " + secondNum + " ");
            for (int i = 2; i < num; i++)
            {
                nextNum = firstNum + secondNum;
                Console.Write(nextNum + " ");
                firstNum = secondNum;
                secondNum = nextNum;
            }
        }
    }
}
