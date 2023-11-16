using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class GenricArrayList
    {
        public static void Method()
        {
            ArrayList cars = new ArrayList();
            cars.Add("BMW");
            cars.Add("TataNano");
            cars.Add("Mercedis");
            cars.Add("Maruti");
            cars.Add("Honda Desire");

            foreach(var x in cars)
            {
                Console.WriteLine(x+" ");

            }

            

            
            
        }
    }
}
