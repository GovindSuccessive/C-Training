using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine("What do you want to do");
                Console.WriteLine("1.Add Subject");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.View All Subjects");
                Console.WriteLine("5.View All Courses");
                Console.WriteLine("6.View All Students");
                Console.WriteLine("7.Find Subject by Name / Code");
                Console.WriteLine("8.Find Course by Name / Code ");
                Console.WriteLine("9.Find Student by Name / Code");
                Console.WriteLine("10.exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bool check = false;
                        Course c = new Course();
                        while (!check)
                        {

                            CourseSubject cs = new CourseSubject();
                            Console.WriteLine("Enter Subject id");
                            cs.Sub_Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Subject Code");
                            cs.Sub_Code = Console.ReadLine();
                            Console.WriteLine("Enter Subject Name");
                            cs.Sub_Name = Console.ReadLine();

                            Console.WriteLine("Do you want to add more subject?");
                            Console.WriteLine("Type Y for yes or N for no");
                            string str = Console.ReadLine();
                            if (!(str.Equals("Y") || str.Equals("y")))
                            {
                                check = true;
                            }
                            c.AddSubject(cs);
                            foreach (var item in c.Subjects)
                            {
                                Console.WriteLine(item.Sub_Id + item.Sub_Name + item.Sub_Code);
                            }
                        }
                        break;
                    case 2:
                        Course cs = new Course();
                        Console.WriteLine("Enter Subject id");
                        cs.Sub_Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Subject Code");
                        cs.Sub_Code = Console.ReadLine();
                        Console.WriteLine("Enter Subject Name");
                        cs.Sub_Name = Console.ReadLine();

                        Console.WriteLine("Do you want to add more subject?");
                        Console.WriteLine("Type Y for yes or N for no");
                        string str = Console.ReadLine();
                        if (!(str.Equals("Y") || str.Equals("y")))
                        {
                            check = true;
                        }
                        c.AddSubject(cs);
                        foreach (var item in c.Subjects)
                        {
                            Console.WriteLine(item.Sub_Id + item.Sub_Name + item.Sub_Code);
                        }
                }
                break;


                break;
                }
            }
        }
    }
}
