using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class GenricHashMap
    {
        public void Method()
        {
            Hashtable Employee = new Hashtable();
            Console.WriteLine("Enter Employee Name");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter Employee Name Having EMployee[{0}]:",i);
                Employee[i] = Console.ReadLine();
            }

            foreach(DictionaryEntry x in Employee)
            {
                Console.WriteLine(x.Key+"->"+x.Value);
            }
        }

        


    }
}
