using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class ThirdLargestNumber
    {
        public static void FindThirdLargestNumber()
        {
            int num;
            Console.Write("Please enter size of the array = ");
            num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("Entert the array elements");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int First_Largest = int.MinValue, S_Largest = int.MinValue, Third_Largest = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                if (arr[i] > First_Largest)
                {
                    First_Largest = arr[i];
                }
            }

            for (int i = 0; i < num; i++)
            {
                if (arr[i] < First_Largest && arr[i] > S_Largest)
                {
                    S_Largest = arr[i];
                }
            }

            for (int i = 0; i < num; i++)
            {
                if (arr[i] < First_Largest && arr[i] < S_Largest && arr[i] > Third_Largest)
                {
                    Third_Largest = arr[i];
                }
            }

            if (First_Largest != int.MinValue && S_Largest == int.MinValue && Third_Largest == int.MinValue)
            {
                //Console.WriteLine("First Largest=" + First_Largest);
                //Console.WriteLine("Second Largest value doesn't exist");
                Console.WriteLine("Third Largest value doesn't exist");

            }
            else if (S_Largest != int.MinValue && Third_Largest == int.MinValue)
            {
                //Console.WriteLine("First Largest=" + First_Largest);
                //Console.WriteLine("Second Largest=" + S_Largest);
                Console.WriteLine("Third Largest value doesn't exist");
            }
            else if (Third_Largest != int.MinValue)
            {
                //Console.WriteLine("First Largest=" + First_Largest);
                //Console.WriteLine("Second Largest=" + S_Largest);
                Console.WriteLine("Third Largest =" + Third_Largest);
            }
        }
    }
}
