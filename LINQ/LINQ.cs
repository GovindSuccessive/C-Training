using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class LINQ
    {
        public static void LinqMethod()
        {
            List<int> val = new List<int>();
            val.Add(5);
            val.Add(8);
            val.Add(2);
            val.Add(13);
            val.Add(78);

            // Using Value Based Linq
            var selected = from x in val
                           where x > 5
                           select x;

            // Method based Linq
            var selval = val.Where(x => x > 5);

            foreach(var x in selval)
            {
                Console.Write(x +" ");
            }

        }

        public static void LinqOperation()
        {
            List<int> val = new List<int>();
            val.Add(5);
            val.Add(8);
            val.Add(2);
            val.Add(13);
            val.Add(78);

            // LInq Sum
            var sum = val.Sum();
            Console.WriteLine("\nSum : "+sum);

            // LInq Max
            var max = val.Max();
            Console.WriteLine("Max : " + max);

            // LInq Min
            var min = val.Min();
            Console.WriteLine("Min : "+ min);

            // LInq Count
            var count = val.Count();
            Console.WriteLine("Count : "+ count);
        }
       
    }
}
