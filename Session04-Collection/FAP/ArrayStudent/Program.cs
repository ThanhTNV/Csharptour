﻿using ArrayStudent.Entities;
using System.Collections;

namespace ArrayStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Student> studentList = new List<Student>();

            //studentList.Add(new Student() {Id = "SE1", Gpa = 8.6, Name = "An", Yob = 2004 });
            //CreateStudent();
        }
        //CHALLENGE #2: HÃY LƯU THÔNG TIN, HỒ SƠ CỦA 30 BẠN SINH VIÊN TRONG PHÒNG NÀY
        //GIẢI PHÁP 1: KHAI BÁO 30 BIẾN STUDENT (CHƠI NGOO)
        //GIẢI PHÁP 2: KHAI BÁO BẰNG MẢNG(NGUYÊN THỦY)
        //GIẢI PHÁP 3: KHAI BÁO BẰNG LIST(MẢNG HIỆN ĐẠI - HẠI ĐIỆN)
        static void PlayWithStudentList()
        {
            Student[] studentList = new Student[30];
            //Mảng nguyên thủy trong C# có thể dùng để chứa Object (Thật vãi cả..)
            foreach (var student in studentList)
            {
                //từng thằng student trong đây là 1 vùng HEAP
                //student chính là studentList[index]
                //nhưng không thể khai báo/gọi hàm constructor để gán cho student, vì student đang trong vòng for each, là 1 biến foreach iteration variable, không thể gán bằng hàm constructor
                //student = new Student() { Id = "SE1", Name = "An" };
            }
            //studentList[0], studentList[1], ... chính là từng biến sinh viên riêng lẻ(Reference Variable), được gom lại và quản lý bởi 1 biến mang tên studentList(cũng là Reference Variable)
            studentList[0] = new Student() { Id = "SE1", Name = "An"};
            studentList[1] = new Student() { Id = "SE2", Name = "Bình" };
            Student s2 = new() { Id = "SE3", Gpa = 8.7, Name = "Cường", Yob = 2004 };
            studentList[2] = s2;
            studentList[3] = studentList[0];

            ArrayList studentList2 = new ArrayList();
            studentList2.Add(new Student());
        }
        static void CreateStudent()
        {
            Student s1 = new Student();//default constructor
                                       //default _backing field
            s1.Id = "SE1";
            s1.Name = "An";
            s1.Gpa = 8.6;
            s1.Yob = 2004;
            s1.ShowProfile();

            Student s2 = new() { Id = "SE2", Gpa = 8.7, Name = "Bình", Yob = 2004 };
            //OBJECT INITIALIZER
            s2.ShowProfile();
        }

        static void HomeWork() 
        {
            //BTVN: HÃY LƯU THÊM 5-10 SINH VIÊN VỚI ĐIỂM LỘN XỘN THỨ TỰ
            //IN RA DANH SÁCH SINH VIÊN
            //SẮP XẾP DS THEO GPA TĂNG DẦN VÀ IN RA MÀN HÌNH
            Student[] studentList = new Student[30];

        }
    }
}


//BTVN: HÃY LƯU THÊM 5-10 SINH VIÊN VỚI ĐIỂM LỘN XỘN THỨ TỰ
//IN RA DANH SÁCH SINH VIÊN
//SẮP XẾP DS THEO GPA TĂNG DẦN VÀ IN RA MÀN HÌNH