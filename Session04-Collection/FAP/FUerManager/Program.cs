using FUerManager.Entities;
using FUerManager.Services;

namespace FUerManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCabinet cabinSE = new StudentCabinet();
            cabinSE.Add(new Student()
            {
                Id = "SE001",
                Name = "An",
                Yob = 2004,
                Gpa = 8.6
            });

            cabinSE.Add(new Student()
            {
                Id = "SE002",
                Name = "Binh"
            });

            LecturerCabinet cabinLecturer = new LecturerCabinet(10);
            cabinLecturer.Add(new Lecturer()
            {
                Id = "00012345",
                Name = "Quan",
                Salary = 20_000_000
            });

            cabinLecturer.Add(new Lecturer()
            {
                Id = "00054321",
                Name = "Dung",
                Salary = 20_000_000
            });
            //SWP391: KHI IN BILL, PAYMENT, TỔNG TIỀN THANH TOÁN PHẢI FORMAT PHẦN NGÀN -> KHÔNG LÀM ĂN ĐÒN

            cabinSE.Print();
            cabinLecturer.Print();
        }
    }
}
