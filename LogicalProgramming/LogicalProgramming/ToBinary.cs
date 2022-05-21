using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class ToBinary
    {
        public static void convertToBinary(int number)
        {
            string num1 = Convert.ToString(number, 2).PadLeft(8, '0'); //Padding for 4 Bytes string = 16
            Console.WriteLine("Decimal to binary representation before swapping \n" + num1);
            
        }
    }
}
