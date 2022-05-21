using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class SwappingNibbles
    {
        public void swapNibbles(int number)
        {
            string num1 = Convert.ToString(number,2).PadLeft(8,'0'); 
            Console.WriteLine("Decimal to binary representation before swapping \n" + num1);
            string nibble = num1.Substring(0,4);
            string nibble1 = num1.Substring(4, 4);
           
            string temp = nibble1;
            nibble1 = nibble;
            nibble = temp;
            string binaryNum2 = nibble + nibble1; ;
            Console.WriteLine("Decimal to binary representation after swapping " + binaryNum2);
            Console.WriteLine("New number after swapping nibbles " + Convert.ToInt32(binaryNum2,2));
        }
    }
}
