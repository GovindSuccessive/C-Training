using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpAdvancedTraining
{
    class ParallelePrograming
    {
        public async static void  SomeMethod()
        {
            Console.WriteLine("SomeMethod is Starting");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.Write("\n");
            Console.WriteLine("SomeMethod is End");
        }
        public static void MethodParallelFor()
        {
            int[] arr = { 2, 4, 23, 24, 3 };
            int n = arr.Length;

            Console.WriteLine("In Standard For Loop \n");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
            Console.WriteLine("\nIn Parallel For Loop");
            Parallel.For(0,n, i =>
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
             
        }

        public static void MethodParallelForEach()
        {
            List<int> val = new List<int>() { 3, 4, 2, 4, 52, 53};

            Console.WriteLine("In Standard ForEach Loop \n");
            foreach (var x in val)
            {
                Console.WriteLine($"val = {x}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
            Console.WriteLine("\nIn Parallel ForEach Loop");
            Parallel.ForEach(val, i =>
            {
                Console.WriteLine(@"value  = {0}, thread = {1}", i, Thread.CurrentThread.ManagedThreadId);
            });


        }
    }
}
