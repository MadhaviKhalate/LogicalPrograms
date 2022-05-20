﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
	internal class CouponNumber
	{
         
        public void DistinctCoupon()
        {
            Random rand = new Random();
            int max = 100000, number, randNum, i;
			String couponCode;
			char[] chars="andhftruehebfwad".ToCharArray();
			Console.WriteLine("Enter value for number of distinct coupon you want ");
			number = Convert.ToInt32(Console.ReadLine());
			for (i = 0; i < number; i++)
			{
				StringBuilder sb = new StringBuilder();
				randNum = Convert.ToInt32(rand.Next() * max);
			
				while (randNum > 0)
				{
					sb.Append(chars[randNum % chars.Length]);
					randNum /= chars.Length;
					//Console.WriteLine(" Distinct Coupon generated : " + i + "number of times");
				}

				couponCode = sb.ToString();
				Console.WriteLine("Coupon Code: " + couponCode);
			}
		}
	}
}
