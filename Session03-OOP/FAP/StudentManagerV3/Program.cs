using StudentManagerV3.Entities;

namespace StudentManagerV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();//xài empty/default constructor - đúng cho Java và C#
            Console.WriteLine("s1 details using toString(): ", s1);
            s1.ShowProfile();

            //muốn sửa info thì chắc chắn phải đem nguyên vật liệu về đổ vào
            //chắc chắn phải dùng setter
            
            //ĐIỀU GÌ XẢY RA NẾU CLASS CỦA BẠN THIẾT KẾ SẴN 1 HAY 1 VÀI CONSTRUCTOR CÓ THAM SỐ???
        }
    }
}
