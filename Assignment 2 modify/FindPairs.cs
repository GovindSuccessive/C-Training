using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class FindPairs
    {
        private static List<int[]> FindMinimumSumPairs1(int[] arr, int sz, int n)
        {
            List<int[]> ans = new List<int[]>();

            for (int i = 0; i < sz; i++)
            {
                for (int j = i + 1; j < sz; j++)
                {
                    if (arr[i] + arr[j] < n)
                    {
                        int[] temp = new int[2];
                        temp[0] = i;
                        temp[1] = j;
                        ans.Add(temp);
                    }
                }
            }
            return ans;
        }
        public static void FindMinimumSumPairs()
        {
            string num;
            int n;
            Console.Write("Enter a Size of the array = ");
            num = Console.ReadLine();

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

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of an array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the Target Elements");
            int k = Convert.ToInt32(Console.ReadLine());

            List<int[]> ans = FindMinimumSumPairs1(arr, n, k);

            foreach (var val in ans)
            {
                Console.WriteLine(val[0] + " " + val[1]);
            }


        }    
    }
}
