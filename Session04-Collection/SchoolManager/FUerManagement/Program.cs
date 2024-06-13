using FUerManagement.Services;
using ListBasic.Entities;

namespace FUerManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentCabinet();
        }

        static void PlayWithStudentCabinet()
        {
            Cabinet<Student> tuSE = new Cabinet<Student>();
            tuSE.AddAnItem(new Student() { Id = "SE1", Name = "An" });
            tuSE.AddAnItem(new Student() { Id = "SE2", Name = "Binh" });

            tuSE.PrintItems();
        }

        static void PlayWithIntegerCabinet()
        {
            Cabinet<int> loto = new Cabinet<int>();
            loto.AddAnItem(5);
            loto.AddAnItem(10);
            loto.AddAnItem(15);
            loto.AddAnItem(20);
            //TYPE-SAFE: KHÔNG ADD LỘN XỘN

            loto.PrintItems();
        }


        //DESIGN PATTERN GOF : 23 PATTERNS
        //SOLID
    }
}
