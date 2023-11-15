using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{
    public struct Data
    {
        public int data_val;
        public Data(int k)
        {
            data_val = k;
        }
    }
    public class Test<T> where T : struct
    {
        private T _value;

        public Test(T value)
        {
            _value = value;
        }

        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }

    }
}
