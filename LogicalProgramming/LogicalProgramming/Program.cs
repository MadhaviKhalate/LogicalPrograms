using System;

namespace LogicalProgramming;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number" +
            "\n5.Coupon Number\n6.StopWatch Program\n7.Vending Maching\n8.Day Of Week\n9.Temperature"+ 
            "Conversion\n10.Monthly Payment.\n11Squart Root.\n12.Convert To Binary\n13.Swap Nibbles");

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
                coupon.DistinctCouponNum();
                break;
            case 6:
                StopWatchTime stop_watch = new StopWatchTime();
                stop_watch.calculateTime();
                break;
            case 7:

                break;
            case 8:

                break;
            case 9:
                TemperatureConversion temp = new TemperatureConversion();
                temp.ConvertTemperature();
                break;
            case 10:

                break;
            case 11:

                break;
            case 12:

                break;
            case 13:

                break;
            default:
                Console.WriteLine("You entered wrong option");
                break;
        }
    }
}