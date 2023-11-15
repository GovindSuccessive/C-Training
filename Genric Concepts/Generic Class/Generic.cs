using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{


   


    public class Generic<T> 
    {
        private T variables;

        public T property1 { get; set; }

        public Generic(T value)
        {
            variables = value;
            property1 = value;
        }

        public T TestMethod(T param)
        {
            Console.WriteLine("Parameter types: {0} and value : {1}", typeof(T).ToString(), param);
            Console.WriteLine("Return types: {0} and value : {1}", typeof(T).ToString(), variables);

            return variables;
        }
/*        public bool IsEqual(int a,int b)
        {
            return a.Equals(b);
        }
        public bool IsEqual(string a, string b)
        {
            return a.Equals(b);
        }*/
        
        public bool IsEqual<T>(T a,T b)
        {
            return a.Equals(b);
        }
    }
}
