using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class MinimumGap
    {
        private static int FindMinimumGap1(string num)
        {
            int ans = 0;
            int diff1 = 0, diff2 = 0;
            int i = 1;
            int n = 0;

            while (!int.TryParse(num, out n))
            {
                Console.WriteLine("Invalid Input,Enter Again");
                num = Console.ReadLine();
            }
          
            while (n < 0)
            {
                Console.WriteLine("Please enter the positive number");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n - i * i >= 0)
            {
                diff1 = n - i * i;
                i++;
            }

            diff2 = -1 * (n - i * i);

            if (diff1 > diff2)
            {
                ans = diff2;
            }
            else
            {
                ans = diff1;
            }
            return ans;
        }
        private static  int FindMinimumGap2(string num)
        {

            int n = 0;

            while (!int.TryParse(num, out n))
            {
                Console.WriteLine("Invalid Input,Enter Again");
                num = Console.ReadLine();
            }
            while (n < 0)
            {
                Console.WriteLine("Please enter the positive number");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int prev_gap = Convert.ToInt32(Math.Floor(Math.Sqrt(n)));
            int forw_gap = Convert.ToInt32(Math.Ceiling(Math.Sqrt(n)));

            if (prev_gap == n && forw_gap == n)
            {
                Console.WriteLine("This is perfect square then gap = " + 0);
            }
            else
            {
                prev_gap = n - prev_gap * prev_gap;
                forw_gap = forw_gap * forw_gap - n;
            }

            if (prev_gap < forw_gap)
            {
                return prev_gap;

            }
            else
            {
                return forw_gap;
            }
        }
        public static  void FindMinimumGap()
        {
            string num;
            Console.Write("Enter a number = ");
            num = Console.ReadLine();
            Console.WriteLine("Minimum difference required to be a perfect square is = " + FindMinimumGap1(num)+" using Method 1");
            Console.WriteLine("Minimum difference required to be a perfect square is = " + FindMinimumGap2(num) + " using Method 2");
        }

    }
}
