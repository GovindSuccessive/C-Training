using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask

    
{
    class Course : CourseSubject
    {
    public const string check = "Hyy";
    
        public int Course_Id;
        public string Course_Name;
        public string Course_Code;
        public List<CourseSubject> CourseSubject;

        static Course()
        {
            CourseSubject cs = new CourseSubject();
            cs.Sub_Id = 101;
            cs.Sub_Code = "EN101";
            cs.Sub_Name = "ENGLISH";
            cs.Course_ID = 001;
            _subject.Add(cs);
        }
           

        private static List<CourseSubject> _subject = new List<CourseSubject>();
        
        public static  List<CourseSubject> Subjects
        {
            get
            {
                return _subject;
            }
        }

        public void AddSubject(CourseSubject cs)
        {
            string id = "";
            int final_id = 0;
            Console.Write("Enter Subject id:");
            id = Console.ReadLine();
            while (id.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }
            while(!int.TryParse(id,out final_id))
            {
                Console.WriteLine("Invalid input,Please enter again");
                id = Console.ReadLine();
            }

            if (Course.Subjects.FirstOrDefault(s => s.Sub_Id == final_id) != null)
            {
                Console.WriteLine("Subject Already Persent in SubjectList");
               
            }
            else
            {
                cs.Sub_Id = final_id;

                string code = "";
                Console.Write("Enter Subject Code:");
                code = Console.ReadLine();
                while (code.Length == 0)
                {
                    Console.WriteLine("Invalid input,Please enter again");
                    code = Console.ReadLine();
                }
                cs.Sub_Code = code;

                string name = "";
                Console.Write("Enter Subject Name:");
                name = Console.ReadLine();
                while (name.Length == 0)
                {
                    Console.WriteLine("Invalid input,Please enter again");
                    name = Console.ReadLine();
                }
                cs.Sub_Name = name;

                Console.WriteLine("Do you want to add this subject to course");
                Console.WriteLine("1 for yes");
                Console.WriteLine("2 for no");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nCourse_ID\tCourse_Code\tCourse_Name");
                foreach (var val in Student.Courses)
                {
                    Console.WriteLine(val.Course_Id + "\t\t" + val.Course_Code + "\t\t" + val.Course_Name);
                }
                Console.Write("Select Course ID From Above List : \n");

                int course_id = 0;
                string iid = "";
                if (choice2 == 1)
                {
                    iid = Console.ReadLine();

                }

                while (!int.TryParse(iid, out course_id))
                {
                    Console.WriteLine("Invalid input! Please enter correct one");
                    iid = Console.ReadLine();
                }

                cs.Course_ID = course_id;
                _subject.Add(cs);
            }
        }
        public void AddSubject(List<CourseSubject> value)
        {
            _subject.AddRange(value);
        }
        public void RemoveSubject(CourseSubject value)
        {
            _subject.Remove(value);
        }

    }
}
