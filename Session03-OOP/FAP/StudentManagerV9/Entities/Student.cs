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

//TỔNG KẾT: CÁCH THIẾT KẾ 1 CLASS LƯU TRỮ INFO CÁC OBJECT
//CÁCH 1: KHAI BÁO CÁC _BACKING FIELD NHƯ BÊN JAVA
//          SAU ĐÓ TẠO GET SET NHƯ BÊN JAVA
//CÁCH 2: KHAI BÁO CÁC _BACKING FIELD NHƯ BÊN JAVA
//          SAU ĐÓ LÀM HÀM GET SET THEO STYLE VIẾT GỘP
//          VÀ XỬ LÝ TRÊN _BACKING FIELD, DÙNG THÊM EXPRESSION BODY NẾU CẦN
//  public string Name { get => _name; set => _name = value;}
//  * QUÊN CÚ PHÁP THÌ GÕ propfull + tab
//  CÁCH NÀY ĐƯỢC GỌI LÀ FULL PROPERTY: HÀM + BACKING FIELD
//CÁCH 3: KHAI BÁO HÀM GET SET THEO STYLE MỚI, NGẮN GỌN, KHÔNG THÈM XÀI _BACKING FIELD, RUNTIME SẼ TỰ GENERATE _BACKING FIELD
//  public string Name { get; set; }
// * QUÊN CÚ PHÁP THÌ GÕ prop + tab
//  CÁCH NÀY ĐƯỢC GỌI LÀ AUTO-IMPLEMENTED PROPERTY
//  (RUNTIME TỰ GENERATE RA _BACKING FIELD CHO TA)
//CÁCH 4: KHAI BÁO _BACKING FIELD NHƯ BÊN JAVA VÀ CHỦ ĐỘNG VIẾT RIÊNG CÁC HÀM GET SET TRUYỀN THỐNG, HOẶC KHÔNG CÓ HÀM GET SET NHƯNG CÓ CÁC HÀM XỬ LÝ _BACKING FIELD