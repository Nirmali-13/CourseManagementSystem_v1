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
        public void gettitle(string Title)
        {
            title= Title;
        }
        public void settitle(string Title)
        {
            title = Title;
        }
        private string Duration;
        public void getduration(string duration)
        {
            Duration = duration;
        }
        public void setduration(string duration)
        {
            Duration= duration;
        }
        private decimal Price;
        public void getprice(decimal price)
        {
            Price=price;
        }
        
    }
}
