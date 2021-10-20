using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemos;
using System.Data.Entity;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Course c = new Course();
            //Console.WriteLine("Enter course id");
            //c.CourseID = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter course name ");
            //c.CourseName = Console.ReadLine();
            //Console.WriteLine("Enter course fees ");
            //c.Fees = Convert.ToDecimal(Console.ReadLine());

            //Mphasis198DBEntities obj = new Mphasis198DBEntities();
            //obj.Courses.Add(c);
            //obj.SaveChanges();
            //Console.WriteLine("Record added successfully....");

            //Course c = new Course();
            //Console.WriteLine("Enter the course id to edit");
            //c.CourseID= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the new name");
            //c.CourseName = Console.ReadLine();
            //Console.WriteLine("Enter new fees");
            //c.Fees = Convert.ToDecimal(Console.ReadLine());
            //Mphasis198DBEntities obj = new Mphasis198DBEntities();
            //Course found=obj.Courses.Find(c.CourseID);
            //found.CourseName = c.CourseName;
            //found.Fees = c.Fees;
            //obj.SaveChanges();
            //Console.WriteLine("Saved the changes");

            //Course c = new Course();
            //Console.WriteLine("Enter the course id to delete");
            //c.CourseID = Convert.ToInt32(Console.ReadLine());
            //Mphasis198DBEntities obj = new Mphasis198DBEntities();
            //Course found = obj.Courses.Find(c.CourseID);
            //obj.Courses.Remove(found);
            //obj.SaveChanges();
            //Console.WriteLine("Delete done");



            //Mphasis198DBEntities obj = new Mphasis198DBEntities();
            //DbSet<Course> courseslist=obj.Courses;
            //foreach (var item in courseslist)
            //{
            //    Console.WriteLine(item.CourseID);
            //    Console.WriteLine(item.CourseName);
            //    Console.WriteLine(item.Fees);
            //    Console.WriteLine("--------------------------");
            //}

            //Student s = new Student();

            //s.Studid = 1001;
            //s.Studname = "Akhil";
            //s.City = "Pune";
            //s.CourseId = 1;
            //Mphasis198DBEntities obj = new Mphasis198DBEntities();
            //obj.Students.Add(s);
            //obj.SaveChanges();
            //Console.WriteLine("Added studnet");


            //Find the course and student details for 1001
            //Student s = new Student();
            //s.Studid = 1001;
            //Mphasis198DBEntities obj = new Mphasis198DBEntities();
            //Student s1=obj.Students.Find(s.Studid);
            //Console.WriteLine(s1.Studid);
            //Console.WriteLine(s1.Studname);
            //Console.WriteLine(s1.CourseId);
            //Console.WriteLine(s1.Course.CourseName);
            //Console.WriteLine(s1.Course.Fees);


            //the students/list of students enrolled for particular course
            Course c = new Course();
            c.CourseID = 1;
          
            Mphasis198DBEntities obj = new Mphasis198DBEntities();
            //  IQueryable<Student> studs=obj.Students.Where(s => s.CourseId ==c.CourseID);//Lazy loading

             IEnumerable<Student> studs=obj.Students.Where(s => s.CourseId ==c.CourseID).ToList();//Eager Loading
                                             
            foreach (var item   in studs)
            {
                Console.WriteLine(item.Studid);
                Console.WriteLine(item.Studname);
                Console.WriteLine(item.City);
                Console.WriteLine("--------------");
            }








            Console.Read();

        }
    }
}
