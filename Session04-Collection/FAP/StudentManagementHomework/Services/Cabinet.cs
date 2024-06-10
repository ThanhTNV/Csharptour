using StudentManagementHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementHomework.Services
{
    internal class Cabinet
    {
        Student[] studentList = new Student[30];
        int _count = 0;
        public int Count { get => _count; }

        public Cabinet(Student[] studentList)
        {
            this.studentList = studentList;
        }
        public Cabinet()
        {
            
        }

        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                studentList[i].ShowProfile();
            }
        }

        public void AddStudent(Student student)
        {
            if (student is not null)
            {
                studentList[Count] = student;
                _count++;
            }
        }

        public void AddStudent(string studentId, string studentName, int yob, double gpa)
        {
            studentList[Count] = new Student() { Id = studentId, Name = studentName, Yob = yob, Gpa = gpa };
            _count++;
        }


    }
}
