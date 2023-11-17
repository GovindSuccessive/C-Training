using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{
    class Student : Course
    {
        public int StudentID;
        public string StudentName;
        public string StudentCode;
        public int Course_Id;
        public List<Course> course;


        private static List<Course> _courses = new List<Course>();
        private static List<Student> _students = new List<Student>();

        public static List<Student> Students
        {
            get
            {
                return _students;
            }
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        static Student()
        {
            Course c = new Course();
            c.Course_Id = 001;
            c.Course_Code = "PD001";
            c.Course_Name = "Personality Development";

            _courses.Add(c);
        }
        public void AddCourse(Course c2)
        {
            string id = "";
            int final_id = 0;
            Console.Write("Enter Course id:");
            id = Console.ReadLine();
            while (id.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }
            while (!int.TryParse(id, out final_id))
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }
            if (Student.Courses.FirstOrDefault(s => s.Course_Id == final_id) != null)
            {
                Console.WriteLine("\nCourse Already Persent !");
            }
            else
            {
                c2.Course_Id = final_id;

                string code = "";
                Console.Write("Enter Course Code:");
                code = Console.ReadLine();
                while (code.Length == 0)
                {
                    Console.WriteLine("Invalid input,Please enter again");
                    code = Console.ReadLine();
                }
                c2.Course_Code = code;

                string name = "";
                Console.Write("Enter Course Name:");
                name = Console.ReadLine();
                while (name.Length == 0)
                {
                    Console.WriteLine("Invalid input,Please enter again");
                    name = Console.ReadLine();
                }
                c2.Course_Name = name;

                _courses.Add(c2);
            }
        }
        public void AddCourse(List<Course> value)
        {
            _courses.AddRange(value);
        }
        public void RemoveCourse(Course value)
        {
            _courses.Remove(value);
        }

        public void AddStudent()
        {
            string id = "";
            int final_id = 0;
            Console.Write("Enter Student id:");
            id = Console.ReadLine();
            while (id.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }
            while (!int.TryParse(id, out final_id))
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }
            if (Student.Students.FirstOrDefault(s => s.StudentID == final_id) != null)
            {
                Console.WriteLine("Student Already Persent !");
            }
            else
            {
                this.StudentID = final_id;

                string code = "";
                Console.Write("Enter Student Code:");
                code = Console.ReadLine();
                while (code.Length == 0)
                {
                    Console.WriteLine("Invalid input,Please enter again");
                    code = Console.ReadLine();
                }
                this.StudentCode = code;

                string name = "";
                Console.Write("Enter Student Name:");
                name = Console.ReadLine();
                while (name.Length == 0)
                {
                    Console.WriteLine("Invalid input,Please enter again");
                    name = Console.ReadLine();
                }
                this.StudentName = name;

                _students.Add(this);
            }

            if (_courses.Count == 0)
            {
                Console.WriteLine("There is not ");
            }
        }
    }
}
