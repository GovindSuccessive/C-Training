using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{
    
    interface Ipolygon
    {
        double CalculateArea(double radius);
    }
    public struct circle:Ipolygon
    {
        public double radius;

        public double CalculateArea(double r)
        {
            return 3.14 * r * r;
        }
    }
    class ICombined
    {


    }
}
