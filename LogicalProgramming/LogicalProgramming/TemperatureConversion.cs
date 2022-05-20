using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class TemperatureConversion
    {
        double fah_Temp, cel_Temp;
        public void ConvertTemperature()
        {
            Console.WriteLine("Enter the temperature to convert");
            Double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter C for celsius and F for fahrenheit");
            Char unit = Convert.ToChar(Console.ReadLine());
            if (char.ToLower(unit) == 'c')
            {
                fah_Temp = ((temp * 9) / 5) + 32;
                Console.WriteLine("{0} celsius is converted to {1} fahrenheit", temp, fah_Temp);

            }
            else if (char.ToLower(unit) == 'f')
            {
                cel_Temp = ((temp - 32) * 5) / 9;
                Console.WriteLine("{0} fahrenheit is converted to {1} celsius", temp, cel_Temp);
            }
        }
    }
}
