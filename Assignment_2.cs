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

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("What do you want to do?\n");
                Console.WriteLine("1. Find the BI (balanced index) number: it is the index of an integer arr for which,sum of lower indexed value = sum of higher indexed value;\n");
                Console.WriteLine("2. Find the Leaders in an arr Given an integer arr A containing N distinct integers, you have to find the count of all the leaders in arr A.\n");
                Console.WriteLine("3. Lazy person's switch action A wire connects N light bulbs.\n");
                Console.WriteLine("4.Maximum Sum of an array\n");
                Console.WriteLine("Break\n");

                Console.WriteLine("\tWhat do you want to run?");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                         int n;
                        int sum = 0;

                        Console.Write("Enter the size of an arr = ");
                        n = Convert.ToInt32(Console.ReadLine());

                        int[] arr = new int[n];
                        Console.WriteLine("Enter the arr elemenst");

                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                            sum += arr[i];
                        }

                        Console.WriteLine("Index of the balance point is = " + FindBalancePoint(arr, n, sum));
                        
                        break;

                    case 2:
                        int n1;

                        Console.Write("Enter the size of an arr = ");
                        n1 = Convert.ToInt32(Console.ReadLine());

                        int[] arr1 = new int[n1];
                        Console.WriteLine("Enter the arr elemenst");

                        for (int i = 0; i < n1; i++)
                        {
                            arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("Total Leaders are = " + CountLeaders(arr1, n1));
                        break;

                    case 3:
                        int n2;
                        Console.Write("Enter the size of an arr = ");
                        n2 = Convert.ToInt32(Console.ReadLine());

                        int[] arr2 = new int[n2];
                        Console.WriteLine("Enter the arr elemenst");

                        for (int i = 0; i < n2; i++)
                        {
                            arr2[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("minimum count = " + MinimumCount(arr2));
                        break;
                    case 4:
                        int n3;
                        Console.Write("Enter the size of an arr = ");
                        n3 = Convert.ToInt32(Console.ReadLine());

                        int[] arr3 = new int[n3];
                        Console.WriteLine("Enter the arr elemenst");

                        for (int i = 0; i < n3; i++)
                        {
                            arr3[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("Maximum sum = " + MaximumSum(arr3, n3));
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("please do right choice");
                        break;
                }

                Console.WriteLine("\tdo you want to run? Enter Y for yes or N for no");
                char ch= Convert.ToChar(Console.ReadLine());
                if (ch=='Y' || ch == 'y')
                {
                    flag = true;
                }
                else if(ch=='N' || ch=='n')
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please enter write choice yes for y and no for n");
                }
            }


            Console.ReadKey();

        }
    }
}
