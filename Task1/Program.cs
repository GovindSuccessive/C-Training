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
                 Console.WriteLine("--->WHAT DO YOU WANT TO DO<-----\n");
                 Console.WriteLine("1.Add Subject");
                 Console.WriteLine("2.Add Course");
                 Console.WriteLine("3.Add Student");
                 Console.WriteLine("4.View All Subjects");
                 Console.WriteLine("5.View All Courses");
                 Console.WriteLine("6.View All Students");
                 Console.WriteLine("7.Find Subject by Name / Code");
                 Console.WriteLine("8.Find Course by Name / Code ");
                 Console.WriteLine("9.Find Student by Name / Code");
                 Console.WriteLine("10.exit\n");

                 int choice = Convert.ToInt32(Console.ReadLine());

                 switch (choice)
                 {
                     case 1:
                         if (Student.Courses.Count == 0)
                         {
                             Console.WriteLine("No Course is persent till now Please add course first");
                         }
                         else
                         {
                             bool check = false;
                             Course c = new Course();
                             while (!check)
                             {
                                 CourseSubject cs = new CourseSubject();
                                 Console.WriteLine("Do you want to add this subject to course");
                                 Console.WriteLine("1 for yes");
                                 Console.WriteLine("2 for no");
                                 int choice2 = Convert.ToInt32(Console.ReadLine());
                                 string final_id ="";
                                 if(choice2 == 1)
                                 {
                                     string id = Console.ReadLine();

                                 }
                                 c.AddSubject(cs);
                                 Console.WriteLine("Do you want to add more subject?");
                                 Console.WriteLine("Type Y for yes or N for no");
                                 string str = Console.ReadLine();
                                 if ((str.Equals("N") || str.Equals("n")))
                                 {
                                     check = true;
                                 }
                             }
                             Console.WriteLine("Subject added Successfully!\n");
                         }
                         break;
                     case 2:
                         if(Student.Students.Count==0)
                         {
                             Console.WriteLine("No student are persent,Please enter Student first");
                         }
                         else
                         {
                             bool check2 = false;
                             Student s = new Student();
                             while (!check2)
                             {
                                 Course c2 = new Course();
                                 s.AddCourse(c2);
                                 Console.WriteLine("Do you want to add more Course?");
                                 Console.WriteLine("Type Y for yes or N for no");
                                 string str2 = Console.ReadLine();
                                 if ((str2.Equals("N") || str2.Equals("n")))
                                 {
                                     check2 = true;
                                 }
                             }
                             Console.WriteLine("Course added Successfully!");
                         }
                         break;
                     case 3:
                         bool check3 = false;
                         Student s1 = new Student();
                         while (!check3)
                         { 
                             s1.AddStudent();
                             Console.WriteLine("Do you want to add more Course?");
                             Console.WriteLine("Type Y for yes or N for no");
                             string str3 = Console.ReadLine();
                             if ((str3.Equals("N") || str3.Equals("n")))
                             {
                                 check3 = true;
                             }
                         }
                         Console.WriteLine("Student Registered Successfully!");
                         break;
                     case 4:
                         Console.WriteLine("Sub_ID\tSub_Code\tSub_Name");
                         foreach(var val in Course.Subjects)
                         {
                             Console.WriteLine(val.Sub_Id+"\t"+val.Sub_Code+"\t\t"+val.Sub_Name);
                         }
                         break;
                     case 5:
                         Console.WriteLine("Course_ID\tCourse_Code\tCourse_Name");
                         foreach (var val in Student.Courses)
                         {
                             Console.WriteLine(val.Course_Id + "\t\t" + val.Course_Code + "\t\t" + val.Course_Name);
                         }
                         break;
                     case 7:
                         Console.WriteLine("Wants to find the Subject,Please Enter Subject Code or Subject Id");
                         string inputFiled = Console.ReadLine();
                         var subject = Course.Subjects.FirstOrDefault(s => s.Sub_Code.ToLower() == inputFiled || s.Sub_Name.ToLower() == inputFiled);
                         Console.WriteLine(subject.Sub_Id + "\t" + subject.Sub_Code + "\t" + subject.Sub_Name);
                         break;
                     case 8:
                         Console.WriteLine("Wants to find the Course, Please Enter Course Code or Course ID");
                         string inputFiled2 = Console.ReadLine();
                         var course = Student.Courses.FirstOrDefault(s => s.Course_Code.ToLower() == inputFiled2 || s.Course_Name.ToLower() == inputFiled2);
                         Console.WriteLine(course.Course_Code + "\t" + course.Course_Id + "\t" + course.Course_Name);
                         break;
                     default:
                         break;
                 }



             }
           
        }
    }
}
