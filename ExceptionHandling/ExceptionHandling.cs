using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{
    class ExceptionHandling
    {
        public void MethodIndexOutOfRange()
        {
            int[] arr = { 2, 4, 5, 2, 5 };
            int n = arr.Length;
            try
            {

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("arr[{0}]:{1}", i, arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("arr[{0}]:{1}", i, arr[i]);
                }
            }

        }

        public void MethodDivideByZero()
        {
            int a = 5;
            int b = 0;

            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MethodFormateException()
        {
            string str = "234#gs";
            int val=0;
            try
            {
                val = int.Parse(str);
                Console.WriteLine("Values : " + val);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Values : "+ val);
            }
        }
        public void DisplayCities(IList<string> cities)
        {
            try
            {
                if (cities == null)
                {
                    throw new ArgumentNullException("cities", "The cities list is null.");
                }

                foreach (var city in cities)
                {
                    Console.WriteLine(city);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MethodNullReferenceExeption()
        {
            IList<string> cities = null;

            try
            {
                DisplayCities(cities);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



    }
}
