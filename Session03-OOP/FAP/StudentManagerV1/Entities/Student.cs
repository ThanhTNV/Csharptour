using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    internal class Student
    {
        private string _id;     //__________
        private string _name;   //__________
        private int _yob;       //__________
        private double? _gpa;   //__________

        public Student() { }

        public Student(string id, string name, int yob, double? gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        //ĐẶC TÍNH CỦA 1 OBJ THÌ ĐƯỢC GỌI LÀ FIELD/ATTRIBUTE/PROPERTY
        //HÀNH ĐỘNG CỦA 1 OBJ THÌ ĐƯỢC GỌI LÀ METHOD(CHÍNH LÀ HÀM)
        //=> HÀM/METHOD + BIẾN/FIELD GỌI CHUNG LÀ MEMBER, THÀNH VIÊN, THÀNH PHẦN CỦA 1 OBJ

        public void ShowProfile()
        {
            Console.WriteLine("Here is my profile");
            Console.WriteLine("ID: " + _id);
            Console.WriteLine(@$"Name: {_name}");//verbatim
            Console.WriteLine("Yob: {0}", _yob);//Placeholder
            Console.WriteLine($"GPA: {_gpa}");//interpolation
        }

        //@Override: JAVA
        public override string ToString()
        {
            return $"ID: {_id} | Name : {_name} | Yob: {_yob} | GPA: {_gpa}";
        }
        //7 tháng deadline
        //  MERN  : 4 tháng
        //      MongoDB
        //      ExpressJS
        //      ReactJS
        //      NodeJS
        //  NestJS: 1 tháng

        //BỘ HÀM CHỈNH SỬA INFO CỦA 1 OBJECT: SET/SETTER
        //CHỈNH SỬA NGHĨA LÀ PHẢI ĐƯA INFO MỚI VÀO, ĐÈ VÀO INFO CŨ
        //GIỐNG NHƯ TA MUA ĐIỆN THOẠI, TA UPLOAD HÌNH MỚI ĐÈ LÊN HÌNH NỀN MẶC ĐỊNH ---> NGOÀI ĐỔ VÀO TRONG
        public void SetId(string id) => _id = id;

        public void SetName(string name) => _name = name;

        public void SetYob(int yob) => _yob = yob;

        public void SetGpa(double gpa) => _gpa = gpa;
        //Expression Body: Rút gọn tên hàm khi chỉ có 1 lệnh

        public string GetId() => _id;
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double? GetGpa() => _gpa;

    }
}

//TRONG OOP:
//OBJECT - đối tượng là 1 thứ quanh ta, dùng nhiều lời để mô tả về nó.VD: Cây bút trên tay có giá tiền, hãng sản xuất, màu sắc,...
//ĐỐI TƯỢNG thì được mô tả qua đặc điểm(field/prop) và hành vi - hành động(method)
//Pet nhà mình có: tên, năm sinh, tiêm ngừa chưa.
//                 hành động: sủa, kêu, cào cấu,...
//CÁC ĐỐI TƯỢNG đều được cho 1 cái tên gọi: CÁI BÚT CỦA TÔI, BÉ CƯNG NHÀ BẠN, TUI, BẠN, THẰNG TÈO, THẰNG TÍ, SẾP, ...
//DANH TỪ RIÊNG:    Tên gọi cho 1 đối tượng cụ thể nào đó
//CÁC ĐỐI TƯỢNG QUANH TA ĐƯỢC CHIA THÀNH CÁC NHÓM DỰA THEO ĐẶC ĐIỂM CHUNG/ĐIỂM TƯƠNG ĐỒNG. TA GOM CÁC ĐỐI TƯỢNG THÀNH 1 NHÓM, ĐẶT CHO CHÚNG 1 CÁI TÊN - CLASS XUẤT HIỆN
//-> CLASS LÀ TÊN GỌI CHUNG, DANH TỪ CHUNG CHO 1 NHÓM ĐỐI TƯỢNG TƯƠNG ĐỒNG
//class Student đại diện cho 1 nhóm sinh viên: an, binh, cuong, dung
//class như cái khuôn, dùng để đúc ra các đối tượng.VD: Student có an, binh, cuong, dung,...
//Các đối tượng này đều chia sẻ đặc tính: id, name, yob, gpa...
//TỪ ĐỐI TƯỢNG TÌM RA CLASS, TỪ CLASS CLONE RA ĐỐI TƯỢNG
//GIÚP TA QUẢN LÝ MỌI OBJECT, MỌI INFO QUANH TA
