using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class Program
    {

            static string RemoveSpace(string str)
        {
            string ans="";

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ' && (i + 1 < str.Length && str[i + 1] == ' '))
                {
                    continue;
                }
                else
                {
                    ans += str[i];
                }
            }

            return ans;
        }
            static void Main(string[] args)
            {

                //Q1. Write a program to check given number is a perfect number or not?

                int n;
                Console.Write("Enter a number: ");
                n = Convert.ToInt32(Console.ReadLine());
            /*
                        int sum=0;

                                    for(int i = 1; i <=n/2; i++)
                                    {
                                        if (n % i == 0)
                                        {
                                            sum += i;
                                        }
                                    }

                                    if (sum == n)
                                    {
                                        Console.WriteLine("the number {0} is perfect number",n);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not a perfect number");
                                    }
                        */


            // Q2 Write a program to Find the minimum gap to make the given number a perfect squre.

            /*
             //Aprroch:1
                
                        int ans = 0;
                        int diff1 = 0,diff2=0;
                        int i = 1;

                        if (n < 0)
                        {
                            Console.WriteLine("Please enter the positive number");
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

                        Console.WriteLine("Minimum difference required to be a perfect square is = "+ans);

            */

            // Aproch:2
            /*           int prev_gap = Convert.ToInt32(Math.Floor(Math.Sqrt(n)));
                       int forw_gap =Convert.ToInt32( Math.Ceiling(Math.Sqrt(n)));

                       if(prev_gap==n && forw_gap == n)
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
                           Console.WriteLine("Smallest gap to become {0} to be perfect square is {1}",n,prev_gap);
                       }
                       else
                       {
                           Console.WriteLine("Smallest gap to become {0} to be perfect square is {1}",n,forw_gap);
                       }

            */

            // Q3. Write a Program to find out the pairs in an array where the sum of the value at index of the pair is less than a given number.
            /*            
                        int[] arr = { 2, 5, 1, 3, 6, 4 };

                        List<int[]> ans = new List<int[]>();

                        //[Brute Force approach]

                        int sz = arr.Length;

                        for (int i = 0; i < sz; i++)
                        {
                            for (int j = i; j < sz; j++)
                            {
                                if (arr[i] + arr[j] < n && i!=j)
                                {
                                    int[] temp = new int[2];
                                    temp[0] = i;
                                    temp[1] = j;
                                    ans.Add(temp);
                                }
                            }
                        }

                        foreach (var val in ans)
                        {
                            Console.WriteLine(val[0] + " " + val[1]);
                        }
            */

            // Q4. Write a program to check the given string number is magical or not?
            /*
                        string str;
                        Console.Write("Enter the number to check the given number is magical or not :- ");
                        str = Console.ReadLine();

                        int num = int.Parse(str);
                        int sum = 0;
                        bool flag = true;
                        int temp = num;
                        while (flag)
                        {
                            sum+= temp % 10; ;
                            temp /= 10;
                            if(sum / 10 == 0 && temp==0 && sum!=1)
                            {
                                Console.WriteLine("This is not a magical number");
                                flag = false;
                                break;
                            }
                            if (sum == 1)
                            {
                                Console.WriteLine("This is a magical number");
                                break;
                            }
                            if (temp == 0 )
                            {
                                temp = sum;
                                sum = 0;
                            }
                        }
            */
           


            //Q5. Write a program to remove multiple spaces from the given string and make sure there is single space between all words.

            /*            string str = "  i  am   a    govind    sharma";

                        int len = str.Length;

                        string ans="";

                        str = str.Trim();

                        ans = RemoveSpace(str);

                        foreach(var val in ans)
                        {
                            Console.Write(val);
                        }*/
            //-------------------------------------------------------------------------------------------------------------
            /*          int s = 0;
                        int e = 1;

                        while (e < len)
                        {
                            if ((str[s] != ' ' && str[e] != ' ') || (str[s] != ' ' && str[e] == ' '))
                            {
                                s++;
                                e++;
                            }
                            else if (str[s] == ' ' && str[e] == ' ')
                            {
                                while (str[e] == ' ')
                                {
                                    e++;
                                }
                                while (str[e] != ' ')
                                {

                                }
                            }
                        }
            */
            //Q6. Write a program to find the third largest number in the integers array.
            /*
                        int num;
                        Console.Write("Please enter size of the array = ");
                        num = Convert.ToInt32(Console.ReadLine());

                        int[] arr = new int[num];

                        Console.WriteLine("Entert the array elements");
                        for(int i = 0; i < num; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        int First_Largest = int.MinValue, S_Largest = int.MinValue, Third_Largest = int.MinValue;

                        for(int i = 0; i < num; i++)
                        {
                            if (arr[i] > First_Largest)
                            {
                                First_Largest = arr[i];
                            }
                        }

                        for(int i = 0; i < num; i++)
                        {
                            if(arr[i]<First_Largest && arr[i] > S_Largest)
                            {
                                S_Largest = arr[i];
                            }
                        }

                        for(int i = 0; i < num; i++)
                        {
                            if(arr[i]<First_Largest && arr[i]<S_Largest && arr[i] > Third_Largest)
                            {
                                Third_Largest = arr[i];
                            }
                        }

                        if (First_Largest!=int.MinValue && S_Largest==int.MinValue && Third_Largest==int.MinValue)
                        {
                            Console.WriteLine("First Largest=" + First_Largest);
                            Console.WriteLine("Second Largest value doesn't exist");
                            Console.WriteLine("Third Largest value doesn't exist");

                        }
                        else if(S_Largest!=int.MinValue && Third_Largest==int.MinValue)
                        {
                            Console.WriteLine("First Largest=" + First_Largest);
                            Console.WriteLine("Second Largest=" + S_Largest);
                            Console.WriteLine("Third Largest value doesn't exist");
                        }
                        else if(Third_Largest!=int.MinValue)
                        {
                            Console.WriteLine("First Largest=" + First_Largest);
                            Console.WriteLine("Second Largest=" + S_Largest);
                            Console.WriteLine("Third Largest =" + Third_Largest);
                        }

            */

            //Q7. Write a program to find the product of an array except itself.

            /*           int num;
                       int left_mul = 1;
                       Console.Write("Please enter size of the array = ");
                       num = Convert.ToInt32(Console.ReadLine());

                       int[] arr = new int[num];
                       int[] ans_arr = new int[num];

                       Console.WriteLine("Entert the array elements");
                       for (int i = 0; i < num; i++)
                       {
                           arr[i] = Convert.ToInt32(Console.ReadLine());
                       }
                       ans_arr[num - 1] = arr[num - 1];
                       for(int i = num-2; i >=0; i--)
                       {
                           ans_arr[i] = ans_arr[i + 1] * arr[i];
                       }

                       for (int i = 0; i < num-1; i++)
                       {
                           ans_arr[i] = left_mul * ans_arr[i + 1];
                           left_mul *= arr[i];
                       }
                       ans_arr[num - 1] = left_mul;

                       foreach (var val in ans_arr)
                       {
                           Console.Write(val+" ");
                       }


           */

            Console.ReadKey();

            }
        }
    }
