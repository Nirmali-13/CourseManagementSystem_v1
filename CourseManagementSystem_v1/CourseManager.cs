using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        public List<Course> courses=new List<Course>();
        
        public void CreateCourse(string title, string duration, decimal price)
        {
            var course = ((courses.Count + 1), title, duration, price);
            courses.FirstOrDefault();

  
        }
        public void ReadCourses()
        {
           if (courses == null)
            {
                Console.WriteLine("no course found");
            }
           else
            {
                foreach (var course in courses)
                {
                    Console.WriteLine(@"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}");
                }
            }
        }
        //public void UpdateCourse(string id, string title, string duration, decimal price)
        //{

        //    foreach (var course in courses)
        //    {
        //        var course1=course.find(c => c.id == id);

        //    }
        //}


    }
}
