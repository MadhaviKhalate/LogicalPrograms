using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class TemparatureConversion
    {
        double fahrenTemp, celciTemp;
        public void ConvertTemperatureUnit()
        {
            Console.WriteLine("Enter the temperature to convert");
            Double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter C for celsius and F for fahrenheit");
            Char unit = Convert.ToChar(Console.Read());

            if (char.ToLower(unit) == 'c')
            {
                fahrenTemp = ((temperature * 9) / 5) + 32;
                Console.WriteLine("{0} celsius is converted to {1} fahrenheit", temperature, fahrenTemp);

            }
            else if (char.ToLower(unit) == 'f')
            {
                celciTemp = ((temperature - 32) * 5) / 9;
                Console.WriteLine("{0} fahrenheit is converted to {1} celsius", temperature, celciTemp);
            }
        }
    }
}
