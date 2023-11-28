using System;
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
            var orderListDes = studentList.OrderByDescending(x => x.Age);
            foreach(var x in orderList)
            {
                Console.Write(x+" ");
            }

            //Linq OrderByDescending
            Console.WriteLine("\n");
            Console.WriteLine("Id Name Age");
            foreach(var x in orderListDes)
            {
                Console.WriteLine("{0} {1} {2} ", x.StudentID, x.StudentName, x.Age); 
            }

            //Linq ThenBy
            Console.WriteLine("\n");
            Console.WriteLine("Age Name");
            var data = studentList.OrderBy(x => x.StudentName).ThenBy(x => x.Age);
            foreach (var x in data)
            {
                Console.WriteLine(x.Age + " :" + x.StudentName);
            }

            //Linq ThenByDescending
            Console.WriteLine("\n");
            Console.WriteLine("Age Name");
            var dataDec = studentList.OrderByDescending(x => x.StudentName).ThenBy(x => x.Age);
            foreach (var x in dataDec)
            {
                Console.WriteLine(x.Age + " :" + x.StudentName);
            }

            //Linq First or FirstDefault
            var stu = studentList.First(x => x.Age == 20);
            Console.WriteLine("\n");
            Console.WriteLine("First Element : " + stu.StudentName);

            var stuFirstordef = val.FirstOrDefault(x=>x==7);
            Console.WriteLine("FirstorDefault Element : " + stuFirstordef);


            //Linq Last or LastorDefault
            var a = studentList.Last(x => x.Age == 20);
            Console.WriteLine("\n");
            Console.WriteLine("Last Element : " + stu.StudentName);

            var b = val.LastOrDefault(x => x == 7);
            Console.WriteLine("LastorDefault Element : " + stuFirstordef);

            //Linq Single or SingleDefault
            List<int> cont = new List<int>() { 2, 5, 22, 32 };
            Console.WriteLine("\nSingle Value : "+cont.Where(x=>x>30).Single());
            Console.WriteLine("Single or Defualt Value : " + cont.Where(x => x > 50).SingleOrDefault());

            //Linq Skip or SkipWhile
            var c = cont.Skip(2);
            Console.WriteLine("\nSKip");
            foreach(var x in c)
            {
                Console.Write(x+" ");
            }

            var d = cont.SkipWhile(x => x < 3);
            Console.WriteLine("\nSKipWhile");
            foreach (var x in d)
            {
                Console.Write(x+" ");
            }

            // Take or TakeWhile
            var e = cont.Take(3);
            Console.WriteLine("\n\nTake");
            foreach (var x in e)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n\nTakeWhile");
            var f = cont.OrderBy(x=>x).TakeWhile(x => x < 10);
            foreach (var x in f)
            {
                Console.Write(x + " ");
            }




        }
       
    }
}
