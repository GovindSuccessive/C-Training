using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsTask
{
    class Course
    {
        public int Course_Id;
        public string Course_Name;
        public string Course_Code;

        private List<CourseSubject> _subject = new List<CourseSubject>();

        public void AddSubject(CourseSubject value)
        {
            _subject.Add(value);
        }

        public List<CourseSubject> Subjects
        {
            get
            {
                return _subject;
            }
        }
        public void RemoveSubject(CourseSubject value)
        {
            if (_subject.Count > 1)
            {
                _subject.Remove(value);
            }
        }

    }
}
