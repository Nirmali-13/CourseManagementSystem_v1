using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class DigitalCourse : Course
    {
        public string CourceLink;
        public int FileSize;
        public DigitalCourse(string courcelink,int fileSize,string courseId, string title, string duration, decimal price) : base(courseId, title, duration, price)
        {
           CourceLink = courcelink;
            FileSize = fileSize;  
        }
        public void DisplayDigitalCourseInfo()
        {
            Console.WriteLine(@"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price},CourceLink:{CourceLink},FileSize:{FileSize}");
        }
    }
}
