using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class VendingMachine
    {
        public void changeForMoney(int money)
        {
            int[] availableNotes = new int[] {1000,500,100,50,20,10,5,2,1};
            int[] changeNotes = new int[10];
            int initialIndex = 0, totalIndex = 9;

            while(initialIndex < totalIndex)
            {
                if(money >= availableNotes[initialIndex])
                {
                    changeNotes[initialIndex] = money / availableNotes[initialIndex];
                    money = money - (changeNotes[initialIndex] * availableNotes[initialIndex]);
                }
                initialIndex++;
            }
            Console.WriteLine("Change for entered amount");
            initialIndex = 0;   
            while (initialIndex < totalIndex)
            {
                Console.WriteLine(availableNotes[initialIndex] + "  Notes are  " + changeNotes[initialIndex]);
                initialIndex++;
            }
        }
    }
}
