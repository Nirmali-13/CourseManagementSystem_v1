using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
        private string courseId;
        public void getcourseid(string courseid)
        {
            courseId = courseid;
        }
        public void setcourseid(string id)
        {
            courseId = id;
        }
        private string title;
        private string Duration;
        private decimal Price;
        
    }
}
