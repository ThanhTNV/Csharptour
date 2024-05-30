using StudentManagerV1.Entities;
using System.Reflection.Metadata.Ecma335;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới hồ sơ sinh viên, 1 bạn cụ thể nào đó
            Student s1 = new Student("SE1", "An", 2004, 8.6);
            //     biến                 OBJECT
            //   tên gọi    được gọi tắt là s1, đây mới là Student thiệt
            s1.ShowProfile();
            //Primitive datatype(java) = value datatype(C#)
            //new ~= malloc/calloc trong C(Cấp vùng nhớ mới để lưu dữ liệu)
            //Biến object được tạo ra và lưu trong vùng nhớ Stack
            //Object được tạo ra bằng câu lệnh new được tạo ra và lưu trong vùng nhớ HEAP
            //Biến object là biến con trỏ, lưu địa chỉ vùng nhớ của Object
            //Cách dùng biến OBJECT giống như dùng con trỏ

            //string msg = s1.ToString();
            //Console.WriteLine("s1 details: \n{0}", s1.ToString());
            Console.WriteLine("s1 details: \n{0}", s1);
            //NẾU GHÉP TÊN BIẾN OBJECT VÀO CHUỖI, BIẾN OBJECT SẼ TỰ ĐỘNG ĐI GỌI HÀM TOSTRING() ĐỂ LẤY CHUỖI BÊN TRONG OBJECT ĐEM ĐI GHÉP

            //ĐIỀU GÌ XẢY RA NẾU TA KHÔNG THÈM TẠO HÀM TOSTRING()
            //->> GỌI HÀM TOSTRING() CỦA CLASS CHA

            //CÁCH TẠO OBJECT #2
            Student s2 = new("SE2", "Binh", 2004, 8.7);//Sau new không cần gọi tên class nhưng vẫn giữ được ý nghĩa gốc do khai báo là Student rồi
            s2.ShowProfile();
            Console.WriteLine(s2);//gọi thầm toString()

            //CÁCH TẠO OBJECT #3
            var s3 = new Student("SE3", "Cuong", 2004, 8.8);
            s3.ShowProfile(); //var: type inferent

            //CÁCH TẠO OBJECT #4
            var s4 = s3; //HAI CHÀNG TRỎ 1 NÀNG
            //không có từ khóa new tức là không có vùng nhớ mới - không có vùng RAM được cấp
            Console.WriteLine("s4 check!!!");
            s4.ShowProfile();
            s4.SetGpa(999);
            Console.WriteLine("s3 check var after s4 modification!!!");
            s3.ShowProfile();
            //LƯU Ý: NẾU BẠN CÓ 1 HÀM NHẬN VÀO BIẾN OBJECT
            //void F(Student x)
            //{
            //}
            //gọi hàm: F(s4); ~~~~~ x = s4 trong hàm
            //trong thân hàm x làm gì thì s4 ngoài hàm ảnh hưởng như vậy, do đó hàm nhận vào biến object chính là đã truyền tham chiếu luôn rồi!!! Do trong hàm và ngoài hàm cùng trỏ 1 vùng RAM new
            //KHÔNG cần dùng out/ref như khi dùng biến là value datatype

        }
    }
}
//DJTME TONG PHUOC QUAN