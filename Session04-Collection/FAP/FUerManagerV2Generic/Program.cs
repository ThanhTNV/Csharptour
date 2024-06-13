using FUerManager.Entities;
using FUerManagerV2Generic.Services;

namespace FUerManagerV2Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet<Student> tuSEStudent = new Cabinet<Student>(30);
            tuSEStudent.Add(new Student() { Id = "SE1", Name = "An" });
            tuSEStudent.Add(new Student() { Id = "SE2", Name = "Binh" });
            tuSEStudent.Print();

            Cabinet<Lecturer> tuSELecturer = new Cabinet<Lecturer>(10);
            tuSELecturer.Add(new Lecturer() { Id = "00012345", Name = "Le Diep", Yob = 1999, Salary = 100_000_000 });
            tuSELecturer.Print();

            //MUA THÊM 1 CÁI TỦ QUẢN LÝ INFO CÁC PET CƯNG: DOG, CAT, ...
        }
    }
}
