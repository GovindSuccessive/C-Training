using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class GenricList
    {
        public void Method()
        {
            List<int> container = new List<int>();

            container.Add(23);
            container.Add(2234);
            container.Add(2423);
            container.Add(23423);
            container.Add(8523);

            foreach(var  x in container)
            {
                Console.WriteLine(x+" ");
            }


        }
    }
}
