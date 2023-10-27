using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {

        static bool  check(int n)
        {
            bool ans = true;
            for (int i = 2; i < n / 2; i++)
            {
                
                if (n % i == 0)
                {
                    ans = false;
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {


            //Q1.count the total number of factors  

            Console.Write("Please enter the value:");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of Factors:" + count);

            /*Q2.check given number is prime or not .
            Q3. find the largest factores of a given number.*/

            bool flag = false;
            int ans = 0;
            for(int i = n; i >=2 ; i--)
            {

                if (check(i))
                {
                    ans = i;
                    break;
                }   
            }
            Console.WriteLine(ans);
            if (!flag)
            {
               
                Console.WriteLine("this is  prime");
            }

            Console.ReadKey();
        }

    }
}
