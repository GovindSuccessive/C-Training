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


        public Course()
        {
            CourseSubject cs = new CourseSubject();
            cs.Sub_Id = 101;
            cs.Sub_Code = "EN101";
            cs.Sub_Name = "ENGLISH";
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
            _subject.Add(cs);
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
