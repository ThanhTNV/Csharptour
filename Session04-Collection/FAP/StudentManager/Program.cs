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
            cabinetBiz.AddAStudent(new Student() { Id = "SS1", Name = "Binh" });
            Console.WriteLine("Tủ chứa hồ sơ sinh viên SE:");
            cabinetSE.ShowList();
            Console.WriteLine("Tủ chứa hồ sơ sinh viên BIZ:");
            cabinetBiz.ShowList();
        }
    }
}
