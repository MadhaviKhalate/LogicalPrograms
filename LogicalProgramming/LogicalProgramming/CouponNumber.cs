using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
	internal class CouponNumber
	{
        int CouponCount = 0, UniqCouponCnt = 0, number;
        Random rand = new Random();
        List<int> couponNumber = new List<int>();
        /*public void DistinctCoupon()
        {
            Random rand = new Random();
			int max = 100, number, i, randNum;
			String couponCode;
			char[] chars = "3284hjfd7234dkfjghdkfkdjf2234cdc".ToCharArray();
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
				}
				couponCode = sb.ToString();
				Console.WriteLine("Coupon Code: " + couponCode);
			}
            int CouponCount = 0, UniqueCouponCount = 0, i = 0;
            Random Random = new Random();
            List<int> couponCodes = new List<int>();      
        }*/
        public void DistinctCoupon()
        {
            Console.WriteLine("Enter value for number of distinct coupon you want ");
            number = Convert.ToInt32(Console.ReadLine());
            while (UniqCouponCnt < number)
            {
                int couponNo = rand.Next();
                CouponCount++;
                if (!couponNumber.Contains(couponNo))
                {
                    couponNumber.Add(couponNo);
                    UniqCouponCnt++;
                }
            }
            foreach (int couponNum in couponNumber)
            {
                Console.WriteLine(couponNum);
            }
            Console.WriteLine("Number of times coupon generated is " + CouponCount);
        }
    }
}
