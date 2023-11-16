using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class GenricArray
    {
        public void CreateOneDimensionalArray()
        {
            int[] arr = new int[5];
            arr[0] = 3;
            arr[1] = 6;
            arr[2] = 3;
            arr[3] = 8;
            arr[4] = 12;
           // arr[5] = 5;//Index out of Bound Array is coming


            foreach(var x in arr)
            {
                Console.Write(x+" ");
            }
        }

        public void CreateTwoDimesionalArray()
        {
            int[,] arr = new int[2,3];

            Console.WriteLine("Enter the Arrays Elements");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Arr[{0}][{1}] : ",i,j);
                    arr[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
            

        }

        public void JaggedArray()
        {
            int[][] jarr = new int[6][];
            jarr[0] = new int[4] { 1, 2, 3, 4 };
            jarr[1] = new int[5] { 84, 42, 90, 11, 56 };
            jarr[2] = new int[2] { 13, 54 };
            jarr[3] = new int[1] { 99 };
            jarr[4] = new int[4] { 19, 22, 93, 42 };
            jarr[5] = new int[2] { 51, 1 };

            for (int i = 0; i < jarr.Length; i++)
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    
                    Console.Write(jarr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        

        
    }
}
