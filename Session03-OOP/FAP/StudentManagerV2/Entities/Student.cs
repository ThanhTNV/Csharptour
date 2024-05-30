using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int? _yob;
        private double? _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }
        public override string ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";
        
        //Ctrl + . để generate constructor và override

        public void SetYob(int yob) => _yob = yob;

        public void SetGpa(double gpa) => _gpa = gpa;

        public void ShowProfile()
            => Console.WriteLine($"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}");
    }
}
