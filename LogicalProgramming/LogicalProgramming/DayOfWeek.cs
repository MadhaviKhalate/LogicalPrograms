using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class DayOfWeek
    {
        public static void dayOfWeekProg(int day1, int month1, int year1)
        {
            int calYear, calMonth, calDay, x;
            string[] WeekDayArray = { "Sunday", "Monday", "Tuesday", "Thursday", "Friday", "Saturday" };

            calYear = year1 - (14 - month1) / 12;
            x = calYear + calYear / 4 - calYear / 100 + calYear/400;
            calMonth = month1 + 12 * ((14 - month1) / 12) - 2;
            calDay = (day1 + x + (31 * calMonth) / 12) % 7;
            
            Console.WriteLine("Day in a week is " + WeekDayArray[calDay]);           
        }
    }
}
