using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{
    class Student
    {
        public int StudentID;
        public string StudentName;
        public string StudentCode;
        public string StudentCourse;


        private List<Course> _courses = new List<Course>();

        public void AddCourse(Course value)
        {
            _courses.Add(value);
        }
        public void AddCourse(List<Course> value)
        {
            _courses.AddRange(value);
        }
        public List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
        public void RemoveCourse(Course value)
        {
            _courses.Remove(value);
        }

    }
}
