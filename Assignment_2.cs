using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_Day_2
{
    class Program
    {
        static int FindBalancePoint(int [] arr,int n,int sum)
        {
            int leftSum = 0;
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (leftSum == sum - arr[i] - leftSum)
                {
                    idx = i;
                    break;
                }
                leftSum += arr[i];

            }

            return idx;
        }

//----------------------------------------------------------------------------------------------------------

        static int CountLeaders(int [] arr,int n)
        {
            int righMax;
            int count = 1;
            righMax = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > righMax)
                {
                    righMax = arr[i];
                    count++;
                }

            }

            return count;

        }
//---------------------------------------------------------------------------------------
        static int MinimumCount(int[] arr)
        {
           
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        arr[i] = 1;
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[j] == 0)
                            {
                                arr[j] = 1;
                            }
                            else
                            {
                                arr[j] = 0;
                            }
                        }
                        count++;
                    }
                }
            return count;
        }

//---------------------------------------------------------------------------------------
        static int MaximumSum(int [] arr,int n)
        {
            int sum = 0;
            int mx = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
                if (sum < 0)
                {
                    sum = 0;
                }
                mx = Math.Max(mx, sum);
            }
            return mx;
        }

        static void Main(string[] args)
        {

            // Assignment 1. Find the BI (balanced index) number: it is the index of an integer arr for which,sum of lower indexed value = sum of higher indexed value;
            /*
                        int n;
                        int sum=0;

                        Console.Write("Enter the size of an arr = ");
                        n = Convert.ToInt32(Console.ReadLine());

                        int[] arr = new int[n];
                        Console.WriteLine("Enter the arr elemenst");

                        for(int i = 0; i < n; i++)
                        {
                            arr[i]= Convert.ToInt32(Console.ReadLine());
                            sum += arr[i];
                        }

                        Console.WriteLine("Index of the balance point is = "+FindBalancePoint(arr,n,sum));
            */

            // Assignment 2.  Find the Leaders in an arr Given an integer arr A containing N distinct integers, you have to find the count of all the leaders in arr A. 
/*
            int n;

            Console.Write("Enter the size of an arr = ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the arr elemenst");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Total Leaders are = " + CountLeaders(arr, n));

*/
            /*
                        Assignment 3.

                        Lazy person's switch action A wire connects N light bulbs.
                        Each bulb has a switch associated with it; however, due to faulty wiring,
                        a switch also changes the state of all the bulbs to the right of the current bulb.
                        Given an initial state of all bulbs, find the minimum number of switches a person have to press to turn on all the bulbs.
                        The person can press the same switch multiple times.

                        Note: 0 represents the bulb is off and 1 represents the bulb is on.
            */
            /*
                        int n;
                        Console.Write("Enter the size of an arr = ");
                        n = Convert.ToInt32(Console.ReadLine());

                        int[] arr = new int[n];
                        Console.WriteLine("Enter the arr elemenst");

                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("minimum count = "+ MinimumCount(arr));

            */

            /*          Assignment 4.
             *          
                        Maximum Subarr
                        You are given an integer arr A of size N.
                        Now you need to find a subarr(contiguous elements)
                        so that the sum of contiguous elements is maximum.
            */


            /*
                        int n;
                        Console.Write("Enter the size of an arr = ");
                        n = Convert.ToInt32(Console.ReadLine());

                        int[] arr = new int[n];
                        Console.WriteLine("Enter the arr elemenst");

                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("Maximum sum = "+MaximumSum(arr,n));
            */
            Console.ReadKey();

        }
    }
}
