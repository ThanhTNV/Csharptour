using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV9.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public Student() { }
        //RUNTIME TỰ SINH RA BACKING FIELD LÚC CHẠY APP
        //GIÚP DÂN DEV VIẾT CODE TIỆN HƠN, TRÁNH CODE NHÀM CHÁN
        //prop + tab : generate mẫu Prop

        //ĐÂY LÀ TRÒ RIÊNG CỦA C#, JAVA KHÔNG CÓ
        //MUỐN LÀM TRÒ NÀY THÌ PHẢI CÀI THÊM DEPENDENCY - THƯ VIỆN LOMBOK

    }
}
