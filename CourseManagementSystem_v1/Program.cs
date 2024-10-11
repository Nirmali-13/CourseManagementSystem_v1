using CourseManagementSystem_v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var manager = new CourseManager();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Course Management System:");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. View All Courses");
                Console.WriteLine("3. Update a Course");
                Console.WriteLine("4. Delete a Course");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choos an option:");
                string option = Console.ReadLine();
            }
            switch opt



        }
    }
}
