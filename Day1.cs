using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Applications
{
    internal class Program
    {

        static void Main(string[] args)
        {


            bool flag = true;

            double Principal = 0.0f;
            while (flag)
            {
                Console.Write("Please enter the principal amount:");

                if (double.TryParse(Console.ReadLine(), out Principal))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please enter the correct principal amount");
                }
            }

            flag = true;
            float Rate = 0.0f;
            while (flag)
            {
                Console.Write("Please enter the Rate of Intrest:");

                if (float.TryParse(Console.ReadLine(), out Rate))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please enter the correct Rate of Intrest");
                }
            }

            flag = true;
            float Time = 0.0f;
            while (flag)
            {
                Console.Write("Please enter the Time Duration:");

                if (float.TryParse(Console.ReadLine(), out Time))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please enter the Time Duration");
                }
            }


            double simpleIntrest = Principal * Rate * Time;
            double amount = simpleIntrest + Principal;
            Console.WriteLine("Simple Intrest:" + simpleIntrest);
            Console.WriteLine("Amount:" + amount);



            ----------------------------------Type Conversion---------------------------------------- -

            //  1. Conversion of int to string,float,decimal,double,char

            int a = 65;

            string a_str = Convert.ToString(a);
            string a_st = a.ToString();

            float f_a = a;

            double d_a = a;

            decimal dm_a = a;

            char ch_a = Convert.ToChar(a);


            //  2. Conversion of float to int,string,decimal,double,char

            float k = 65.6f;

            int i_k = Convert.ToInt32(k);

            double d_k = k;

            decimal dc_K = Convert.ToDecimal(k);
            decimal dcm_k = (decimal)k;

            string str_k = k.ToString();
            string st_k = Convert.ToString(k);

            char ch_k = (char)k;


            // 3. Conversion of string to int(using parse and tryParse)

            string abc = "3423434";
         
            int i_abc = int.Parse(abc);//usin parse when u are sure that string is numeric.
            Console.WriteLine(i_abc);

            int ii_abc;
            bool check_abc = int.TryParse(abc, out ii_abc);










            String s1 = "welcome";
            Console.WriteLine(s1);

            //LENGTH:

            Console.WriteLine(s1.Length);


            //REPLACE:
            Console.WriteLine(s1.Replace('e', 'i'));

            //SPLIT:
            string[] split = s1.Split(new char[] { 'e' });

            //CONACT:
            Console.WriteLine(string.Concat(s1, s2));

            //CONTAIN:
            Console.WriteLine(s1.Contains(s2));

            //HASHCODE:

            Console.WriteLine(s1.GetHashCode());

            //LOWER CASE:

            Console.WriteLine(s1.ToLower());

            //CLONE :
            string s2 = (string)s1.Clone();
            Console.WriteLine(s2);


            //COMPARE:
            Console.WriteLine(string.Compare(s1, s2));



            //UPPER CASE:
            Console.WriteLine(s1.ToUpper());



            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);


            // CONVERT TO CHARACTER ARRAY:
            Console.WriteLine(s1.ToCharArray());




            //USING STRING BUILDER CLASS:

            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder("hello everyone my name is utkarsh srivastava");
            Console.WriteLine(sb1);

            // format string
            string name = "abhay";
            string sb3 = String.Format("Hello {0}", name);

            Console.WriteLine(sb3);
            Console.WriteLine(ch_k);

            Console.ReadKey();
        }

    }
}
