using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV5.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student()
        {
            
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }
        //ctor + TAB : Sinh ra constructor rỗng 1 cách chủ động
        //Constructor có tham số thì dùng Ctrl + .
        //Vậy thì có n cách để đúc 1 object
        //Hoàn thiện 1 object ta dùng Setter

    }
}
