using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class GenricQueue
    {
        public void Method()
        {
            Queue<string> PerfumeName = new Queue<string>();

            PerfumeName.Enqueue("Gucci");
            PerfumeName.Enqueue("BMW");
            PerfumeName.Enqueue("ZX");

            while(PerfumeName.Count!=0)
            {
                Console.WriteLine(PerfumeName.Peek());
                PerfumeName.Dequeue();
            }
        }
    }
}
