using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class FindProductArray
    {
        private static int[] ProductArray(int[] arr, int num)
        {
            int[] ans_arr = new int[num];
            int left_mul = 1;
            ans_arr[num - 1] = arr[num - 1];

            for (int i = num - 2; i >= 0; i--)
            {
                ans_arr[i] = ans_arr[i + 1] * arr[i];
            }

            for (int i = 0; i < num - 1; i++)
            {
                ans_arr[i] = left_mul * ans_arr[i + 1];
                left_mul *= arr[i];
            }
            ans_arr[num - 1] = left_mul;

            return ans_arr;
        }

        public static void FindProductArrays()
        {
            int num;

            Console.Write("Please enter size of the array = ");
            num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];
            int[] ans_arr = new int[num];

            Console.WriteLine("Entert the array elements");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            ans_arr = ProductArray(arr, num);

            foreach (var val in ans_arr)
            {
                Console.Write(val + " ");
            }
        }
    }
}
