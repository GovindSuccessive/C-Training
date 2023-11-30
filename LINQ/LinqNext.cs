using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTraining
{
    class LinqNext
    {
        public static void LinqSelect()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age=32 },
            new Student() { StudentID = 2, StudentName = "Moin",Age=22 },
            new Student() { StudentID = 3, StudentName = "Bill",Age=25 },
            new Student() { StudentID = 4, StudentName = "Ram",Age=19 },
            new Student() { StudentID = 5, StudentName = "Ron",Age=21 }
            };

            Console.WriteLine("Select Operator in Linq");
            var Sage = studentList.Where(s => s.StudentName.ToLower() == "moin").Select(s => new { Name = s.StudentName , Age = s.Age} );
            foreach(var x in Sage)
            {
                Console.WriteLine("Name : {0} Age : {1}",x.Name,x.Age);
            }
        }

        public static void LinqAllAnyMethod()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age=32 },
            new Student() { StudentID = 2, StudentName = "Moin",Age=22 },
            new Student() { StudentID = 3, StudentName = "Bill",Age=25 },
            new Student() { StudentID = 4, StudentName = "Ram",Age=19 },
            new Student() { StudentID = 5, StudentName = "Ron",Age=21 }
            };

                Console.WriteLine("All OutPut");
                if (studentList.All(x => x.Age > 9 && x.Age <= 19))
                {
                    Console.WriteLine("Teenager");
                }
                else if (studentList.All(x => x.Age >= 18))
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Child");

                }

                Console.WriteLine("\nAny OutPut");
                if (studentList.Any(x => x.Age > 9 && x.Age <= 19))
                {
                    Console.WriteLine("Teenager");
                }
                else if (studentList.Any(x => x.Age >= 18))
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Child");
                
                }
        }

        public static void MethodAggregate()
        {
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(commaSeperatedString);
        }

        public static void MethodConcate()
        {
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };

            var collection3 = collection1.Concat(collection2);

            foreach (string str in collection3)
            Console.WriteLine(str);
        }


        public static void MethodDistinct()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age=32 },
            new Student() { StudentID = 2, StudentName = "Moin",Age=22 },
            new Student() { StudentID = 3, StudentName = "Bill",Age=25 },
            new Student() { StudentID = 4, StudentName = "Ram",Age=19 },
            new Student() { StudentID = 4, StudentName = "Ram",Age=19 },
            new Student() { StudentID = 6, StudentName = "Ron",Age=21 }
            };

            var SList = studentList.Distinct(new StudentComparer());
            foreach(var x in SList)
            {
                Console.WriteLine(x.StudentName + " " + x.StudentID);
            }
        }

        public static void MethodExcept()
        {
            IList<Student> studentList1 = new List<Student>() {
             new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
             new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var resultedCol = studentList1.Except(studentList2, new StudentComparer());

            foreach (Student std in resultedCol)
                Console.WriteLine(std.StudentName);
        }

        public static void MethodIntersect()
        {
            IList<Student> studentList1 = new List<Student>() {
             new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
             new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var resultedCol = studentList1.Intersect(studentList2, new StudentComparer());

            foreach (Student std in resultedCol)
                Console.WriteLine(std.StudentName);
        }

        public static void MethodUnion()
        {
            IList<Student> studentList1 = new List<Student>() {
             new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
             new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var resultedCol = studentList1.Union(studentList2, new StudentComparer());

            foreach (Student std in resultedCol)
                Console.WriteLine(std.StudentName);
        }
    }

   
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if ( x.StudentID == y.StudentID  ||  x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}
