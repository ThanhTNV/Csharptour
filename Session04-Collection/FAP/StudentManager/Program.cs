using StudentManager.Entities;
using StudentManager.Services;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet cabinetSE = new Cabinet();//CÓ SẴN NGĂN 30 CHỖ ĐỰNG HỒ SƠ
            Cabinet cabinetBiz = new Cabinet();//CÓ THÊM 30 NGĂN KHÁC CŨNG ĐANG EMPTY
            //2 VÙNG NEW RIÊNG BIỆT, 2 TỦ RIÊNG BIỆT
            cabinetSE.AddAStudent(new Student() { Id = "SE1", Name = "An" });
            cabinetSE.AddAStudent(new Student() { Id = "SE2", Name = "Cuong" });
        }

        
    }
}


//HOMEWORK: ASSIGNMENT #2: LMS - 10/6 (14H59)
//VIẾT THÊM BÊN MAIN() CÁI MENU IN RA
//1. THÊM MỚI
//2. IN
//3. XÓA
//4. THÊM
//...
//NHẬP TỪ BÀN PHÍM
//NHỚ PHẢI BIẾT CÁCH CONVERT TỪ CHUỖI SANG SỐ, PARSE INT

//VIẾT THÊM TỦ ĐỰNG HỒ SƠ GIẢNG VIÊN: ID, NAME, YOB, SALARY
//HỌC GENERIC: <> => LIST<>
//HỌC MÔ HÌNH 3 LỚP: 3-LAYER