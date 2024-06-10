using StudentManagementHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementHomework.Services
{
    internal class StudentManager
    {
        public static Student createStudent()
        {
            Student newStudent = new Student();
            string nId;
            do
            {
                Console.Write("Enter student ID:");
                nId = Console.ReadLine();
                if(nId.Length != 0)
                {
                    break;
                }
                Console.WriteLine("This field is required!");
            } while(true);

            newStudent.Id = nId;

            string nName;
            do
            {
                Console.Write("Enter student's name:");
                nName = Console.ReadLine();
                if (nName.Length != 0)
                {
                    break;
                }
                Console.WriteLine("This field is required!");
            } while (true);

            newStudent.Name = nName;

            Console.Write("Enter student's year of birth:");
            newStudent.Yob = Int32.Parse(Console.ReadLine());

            Console.Write("Enter student's GPA:");
            newStudent.Gpa = Double.Parse(Console.ReadLine());

            return newStudent;
        }
    }
}
