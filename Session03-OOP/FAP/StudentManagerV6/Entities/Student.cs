using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //các cặp Get() Set() truyền thống
        public string GetId() => _id;
        //Ctrl K D: Priettier Format
        public void SetId(string id) => _id = id;
        //public string GetName() => _name;
        //public void SetName(string name) => _name = name;
        public string Name//Property: LAI GIỮA HÀM GET/SET VÀ BIẾN THÔNG THƯỜNG, LỢI DỤNG RẰNG KHAI BÁO 1 BIẾN CHÍNH LÀ ĐÃ KHAI BÁO LUÔN 2 THỨ GET VALUE VÀ SET VALUE CỦA BIẾN
                          //=> TRONG C# PROPERTY != FIELD
        {
            //Vì muốn giảm nhẹ hàm get() set()
            get => _name;//Property readable
            set => _name = value;//Property writable
        }
        public int GetYob() => _yob;
        public void SetYob(int yob) => _yob = yob;
        public double GetGpa() => _gpa;
        public void SetGpa(double gpa) => _gpa = gpa;

    }
}
