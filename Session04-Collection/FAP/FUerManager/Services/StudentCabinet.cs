using FUerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Services
{
    //void F(int size){...}
    //      int là datatype, kiểu dữ liệu, loại dữ liệu, hình dáng của thông tin.
    //      int: 1 con số nguyên(the whole number)
    //Hàm F() cần con số nguyên nào đó
    //      size: là dữ liệu cụ thể, data, 1 con số nào đó bất kì, miễn là nguyên
    //  -> int: cố định, hàm chơi với số nguyên
    //     size: thay đổi, value, con số nguyên cụ thể
    //TRUYỀN THỐNG: HÀM NHẬN VÀO THAM SỐ, NGHĨA LÀ DATATYPE CỐ ĐỊNH, VALUE DATA TYPE THÌ THAY ĐỔI
    //TRUYỀN THỐNG: TRUYỀN THAM SỐ CHÍNH LÀ TRUYỀN 1 "VALUE"
    internal class StudentCabinet
    {
        private Student[] _arr = new Student[30];//hard-code
        private int _count = 0;
        public int Count { get; }
        public StudentCabinet()
        {
            //tủ default là 30 slot
        }
        public StudentCabinet(int size)
        {
            _arr = new Student[size];//tủ custom theo yêu cầu
        }
        public void Print()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the cabinet");
            for (int i = 0; i < _count; i++)
                _arr[i].ShowProfile();
        }
        public void Add(Student student)
        {
            _arr[_count] = student;
            _count++;
        }
        public void Clear()
        {
            _count = 0;
        }
    }
}