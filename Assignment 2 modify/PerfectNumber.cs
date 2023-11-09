using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class PerfectNumber
    {
    private static  bool IsPerfectNumber(int n)
    {

        int sum = 0;
        bool isPerfect = false;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        if (sum == n)
        {
            isPerfect = true;
        }
        return isPerfect;
    }
        public static  void  CheckPerfectNumber()
        {
            int n;
            Console.Write("Enter a number to check a number is perfect  or not = ");
            n = Convert.ToInt32(Console.ReadLine());

            if (IsPerfectNumber(n))
            {
                Console.WriteLine("the number {0} is perfect number", n);
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }

        }
    }
}
