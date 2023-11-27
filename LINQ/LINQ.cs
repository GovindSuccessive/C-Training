﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    public  class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public int Age { get; set; }
    }
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

            IList<Student> studentList = new List<Student>() {
               new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
               new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
               new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
               new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
               new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
               new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };
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

            //Linq OrderBy
            var orderList = val.OrderBy(x=>x);

            foreach(var x in orderList)
            {
                Console.Write(x+" ");
            }

            var data = studentList.OrderBy(x => x.StudentName).ThenBy(x => x.Age);

            foreach (var x in data)
            {
                Console.WriteLine(x.Age + " :" + x.StudentName);
            }

        }
       
    }
}