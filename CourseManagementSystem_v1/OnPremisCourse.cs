using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class OnPremisCourse : Course
    {
        public string Schedule;
        public int ClassroomCapacity;
        public OnPremisCourse(string schedule, int classroomCapacity, string courseId, string title, string duration, decimal price) : base(courseId, title, duration, price)
        {
            Schedule = schedule;
            ClassroomCapacity = classroomCapacity;
        }

       public void DisplayOnPremisCourseInfo()
        {
            Console.WriteLine(@"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price},Schedule:{Schedule}, ClassroomCapacity:{ ClassroomCapacity}");
        }
    }
}
