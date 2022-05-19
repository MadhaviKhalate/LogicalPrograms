using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public void revereNumber()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem, rev = 0;
            while (num > 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed Number is : " + rev);
        }
    }
}
