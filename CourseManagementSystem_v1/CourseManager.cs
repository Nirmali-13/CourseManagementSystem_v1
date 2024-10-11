using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        public List<Course> courses=new List<Course>();
       
        
        public void CreateCourse(string title, string duration, decimal price)
        {

            var courseobj = ((courses.Count + 1), title, duration, price);
            courses.FirstOrDefault();


        }
        public void ReadCourses()
        {
            if (courses.Count > 0)
            {
                foreach (var course in courses)
                {
                    Console.WriteLine(@"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}");
                }
            }
            else
            {
                Console.WriteLine("no course found");
            }
           
               
            

        }
        public void UpdateCourse(string id, string title, string duration, decimal price)
        {
            var course = courses.Find(c => c.courseId == id);
            if (course == null)
            {
                Console.WriteLine("Course not found");
            }
            else
            {
                course.title = title;
                course.Duration = duration;
                course.Price = price;
                Console.WriteLine("Course updated successfully");
            }
        }
        public void DeleteCourse(string id)
        {
            var course = courses.Find(c => c.courseId == id);
            if (course == null)
            {
                Console.WriteLine("Course not found");
            }
            else
            {
                courses.Remove(course); ;
                Console.WriteLine("Course removed successfully");
            }
        }

    }
  


}

