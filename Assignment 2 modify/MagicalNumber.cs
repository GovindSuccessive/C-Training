using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class MagicalNumber
    {
        private static bool IsMagicalNumber1(string str)
        {
            int num = int.Parse(str);
            int sum = 0;
            bool flag = false;
            int temp = num;
            while (!flag)
            {
                sum += temp % 10; ;
                temp /= 10;
                if (sum / 10 == 0 && temp == 0 && sum != 1)
                {
                    break;
                }
                if (sum == 1 && temp == 0)
                {
                    flag = true;
                    break;
                }
                if (temp == 0)
                {
                    temp = sum;
                    sum = 0;
                }
            }
            return flag;
        }
        private static bool IsMagicalNumber2(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            int sum = 0;
            bool endProcess = false;
            while (!endProcess)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    int n = sb[i] - '0';
                    sum += n;
                }
                if (sum >= 10)
                {
                    sb.Clear();
                    sb.Append(sum.ToString());
                    sum = 0;
                }
                else
                {
                    endProcess = true;
                }
            }
            return sum == 1;
        }
        public static void IsMagicalNumber()
        {
            string str;
            Console.Write("Enter the number to check the given number is magical or not :- ");
            str = Console.ReadLine();
 
            //Aprroch 1

            if (IsMagicalNumber2(str))
            {

                Console.WriteLine("This is a magical number ");

            }
            else
            {
                Console.WriteLine("This is not a magical number");
            }
        }
    }
}
