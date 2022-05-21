using System;

namespace LogicalProgramming;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number" +
            "\n5.Coupon Number\n6.StopWatch Program\n7.Vending Maching\n8.Day Of Week\n9.Temperature"+ 
            "Conversion\n10.Monthly Payment.\n11.Squart Root.\n12.Convert To Binary\n13.Swap Nibbles");

        Console.WriteLine("Enter option ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                FibonacciSeries f = new FibonacciSeries();
                f.Fibonacci_Series();
                break;
            case 2:
                PerfectNumber perfect = new PerfectNumber();
                perfect.perfect_Number();
                break;
            case 3:
                PrimeNumber prime = new PrimeNumber();
                prime.primeCheck();
                break;
            case 4:
                ReverseNumber revere = new ReverseNumber();
                revere.revereNumber();
                break;
            case 5:
                CouponNumber coupon = new CouponNumber();
                coupon.DistinctCoupon();
                break;
            case 6:
                StopWatchTime stop_watch = new StopWatchTime();
                stop_watch.calculateTime();
                break;
            case 7:
                VendingMachine vending = new VendingMachine();
                Console.WriteLine("Enter value for Money");
                int moneyValue = Convert.ToInt32(Console.ReadLine());
                vending.changeForMoney(moneyValue);
                break;
            case 8:
                int day, month, year;
                Console.WriteLine("Enter the day");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the month");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the day");
                year = Convert.ToInt32(Console.ReadLine());
                DayOfWeek.dayOfWeekProg(day,month,year);
                break;
            case 9:
                TemparatureConversion temp = new TemparatureConversion();
                temp.ConvertTemperatureUnit();
                break;
            case 10:
                MonthlyPayment.monthlyPayment();
                break;
            case 11:
                Console.WriteLine("Enter value for c");
                int c = Convert.ToInt32(Console.ReadLine());
                SquartRoot.root(c);
                break;
            case 12:
                Console.WriteLine("Enter Value for number");
                int number = Convert.ToInt32(Console.ReadLine());
                ToBinary.convertToBinary(number);
                break;
            case 13:
                SwappingNibbles swap = new SwappingNibbles();
                Console.WriteLine("Enter Value for number");
                int number1 = Convert.ToInt32(Console.ReadLine());
                swap.swapNibbles(number1);
                break;
            default:
                Console.WriteLine("You entered wrong option");
                break;
        }
    }
}