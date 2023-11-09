using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{

    class Program
    {
   
            static void Main(string[] args)
            {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("What do you want to do?\n");
                Console.WriteLine("Q1. Write a program to check given number is a perfect number or not?\n");
                Console.WriteLine("Q2. Write a program to Find the minimum gap to make the given number a perfect squre.\n");
                Console.WriteLine("Q3. Write a Program to find out the pairs in an array where the sum of the value at index of the pair is less than a given number.\n");
                Console.WriteLine("Q4. Write a program to check the given string number is magical or not?\n");
                Console.WriteLine("Q5. Write a program to remove multiple spaces from the given string and make sure there is single space between all words.\n");
                Console.WriteLine("Q6. Write a program to find the third largest number in the integers array.\n");
                Console.WriteLine("Q7. Write a program to find the product of an array except itself.\n");

                Console.WriteLine("What do you want to run?");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PerfectNumber.CheckPerfectNumber();
                        break;
                    case 2:
                        MinimumGap.FindMinimumGap();
                        break;
                    case 3:
                        FindPairs.FindMinimumSumPairs();
                        break;
                    case 4:
                        MagicalNumber.IsMagicalNumber();
                        break;
                    case 5:
                        RemoveMultipleSpaces.RemoveSpace();
                        break;
                    case 6:
                        ThirdLargestNumber.FindThirdLargestNumber();
                        break;
                    case 7:
                        FindProductArray.FindProductArrays();
                        break;
                        
                    default:
                        Console.WriteLine("please do right choice");
                        break;
                }

                Console.WriteLine("\t\ndo you want to solve agian? Enter Y for yes or N for no");
                char ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'Y' || ch == 'y')
                {
                    flag = true;
                }
                else if (ch == 'N' || ch == 'n')
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
