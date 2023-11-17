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

            ExceptionHandling ex = new ExceptionHandling();
            //ex.MethodIndexOutOfRange();
            //ex.MethodDivideByZero();
            //ex.MethodFormateException();
            ex.MethodNullReferenceExeption();
            Console.ReadKey();
            /*     bool flag = false;
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
                             if (Student.Courses.Count <= 1)
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
                                    *//* Console.WriteLine("Do you want to add this subject to course");
                                     Console.WriteLine("1 for yes");
                                     Console.WriteLine("2 for no");
                                     int choice2 = Convert.ToInt32(Console.ReadLine());


                                     int course_id = 0;
                                     string id = "";
                                     if (choice2 == 1)
                                     {
                                         Console.WriteLine("\nCourse_ID\tCourse_Code\tCourse_Name");

                                         foreach (var val in Student.Courses)
                                         {
                                             Console.WriteLine(val.Course_Id + "\t\t" + val.Course_Code + "\t\t" + val.Course_Name);
                                         }
                                         Console.Write("Select Course ID From Above List : \n");

                                         id = Console.ReadLine();

                                        while (!int.TryParse(id, out course_id))
                                        {
                                            Console.WriteLine("Invalid input! Please enter correct one");
                                            id = Console.ReadLine();
                                        }

                                     cs.Course_ID = course_id;
                                     }
     *//*
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
                             if (Student.Students.Count == 0)
                             {
                                 Console.WriteLine("No student are persent for course,Please enter Student first");
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
                             while (!check3)
                             {
                                 Student newStud = new Student();
                                 newStud.AddStudent();
                                 Console.WriteLine("Do you want to add more Student?");
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
                             Console.WriteLine("Sub_ID\tSub_Code\tSub_Name\tCourse_ID");

                             foreach (var val in Course.Subjects)
                             {
                                 Console.WriteLine(val.Sub_Id + "\t" + val.Sub_Code + "\t\t" + val.Sub_Name+"\t\t"+val.Course_ID);
                             }
                             break;
                         case 5:
                             Console.WriteLine("Course_ID\tCourse_Code\tCourse_Name");
                             foreach (var val in Student.Courses)
                             {
                                 Console.WriteLine(val.Course_Id + "\t\t" + val.Course_Code + "\t\t" + val.Course_Name);
                             }
                             break;
                         case 6:
                             Console.WriteLine("Student_ID\tStudent_Code\tStudent_Name");
                             foreach (var val in Student.Students)
                             {
                                 Console.WriteLine(val.StudentID + "\t\t" + val.StudentCode + "\t\t" + val.StudentName+"\n");


                                 foreach (var course in Student.Courses.Where(x => x.Course_Id == val.Course_Id).ToList())
                                 {
                                     Console.WriteLine($"CourseId:{0} CourseName:{1} ",course.Course_Id,course.Course_Name);
                                 }
                             }
                             break;
                         case 7:
                             if (Course.Subjects.Count == 0)
                             {
                                 Console.WriteLine("No Subject is pesent till now");
                             }
                             else
                             {
                                 Console.WriteLine("Wants to find the Subject,Please Enter Subject Code or Subject Name");
                                 string inputFiled = Console.ReadLine();
                                 var subject = Course.Subjects.FirstOrDefault(s => s.Sub_Code.ToLower() == inputFiled || s.Sub_Name.ToLower() == inputFiled);
                                 if (subject != null)
                                 {
                                     Console.WriteLine(subject.Sub_Id + "\t" + subject.Sub_Code + "\t" + subject.Sub_Name);
                                 }
                                 else
                                 {
                                     Console.WriteLine("Subject not found");
                                 }
                             }
                             break;
                         case 8:
                             if (Student.Courses.Count == 0)
                             {
                                 Console.WriteLine("No Course is Persent  till now");
                             }
                             else
                             {
                                 Console.WriteLine("Wants to find the Course, Please Enter Course Code or Course Name");
                                 string inputFiled2 = Console.ReadLine();
                                 var course = Student.Courses.FirstOrDefault(s => s.Course_Code.ToLower() == inputFiled2 || s.Course_Name.ToLower() == inputFiled2);
                                 if (course != null)
                                 {
                                     Console.WriteLine(course.Course_Code + "\t" + course.Course_Id + "\t" + course.Course_Name);
                                 }
                                 else
                                 {
                                     Console.WriteLine("\nCourse Not Found!\n");
                                 }
                             }
                             break;
                         case 9:
                             if (Student.Students.Count == 0)
                             {
                                 Console.WriteLine("\nNo Students have been Enrolled till now!\n");

                             }
                             else
                             {
                                 Console.WriteLine("Wants to find the Student, Please Enter Student Code or Student Name");
                                 string inputFiled3 = Console.ReadLine();
                                 var student = Student.Students.FirstOrDefault(s => s.StudentCode.ToLower() == inputFiled3 || s.StudentName.ToLower() == inputFiled3);
                                 if (student != null)
                                 {
                                     Console.WriteLine(student.StudentID + "\t" + student.StudentCode + "\t" + student.StudentName);
                                 }
                                 else
                                 {
                                     Console.WriteLine("\nStudent Not Found !\n");
                                 }

                             }
                             break;
                         case 10:
                             Console.WriteLine("Thanks For Coming");
                             flag = true;
                             break;
                         default:
                             Console.WriteLine("Invalid Input Please Enter Again\n");
                             break;
                     }



                 }
     */
        }
    }
}
