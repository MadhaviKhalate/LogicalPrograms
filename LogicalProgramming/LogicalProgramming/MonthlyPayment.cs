using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class MonthlyPayment
    {
        public static void monthlyPayment()
        {
            Console.WriteLine("Enter values for Principal,Years,Rate to calculate monthly payment");
            int principal = Convert.ToInt32(Console.ReadLine());
            int years = Convert.ToInt32(Console.ReadLine());
            int rate = Convert.ToInt32(Console.ReadLine());
            int n = years * 12;
            decimal r = (decimal)rate / 1200;
            double payment = (principal * (double)(r)) / (1 - Math.Pow(1 + (double)(r), -n));
            Console.WriteLine("Payment to be made monthly is Rs. " + payment);
        }
    }
}
