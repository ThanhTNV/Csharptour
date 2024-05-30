using StudentManagerV6.Entities;

namespace StudentManagerV6
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void PlayWithGetSet()
        {
            // biến là 1 vùng RAM được đặt tên, chứa giá trị nào đó
            // khi chơi với biến là ta chơi với vùng ram, chơi với giá trị, chơi thông qua tên biến
            // chơi với vùng RAM/biến, ta làm được 2 việc sau:
            //READ VÙNG RAM/BIẾN, COI NÓ CÓ VALUE GÌ
            //WRITE VÙNG RAM/BIẾN, THAY ĐỔI VALUE VÙNG RAM/BIẾN
            int x = 10;//vùng ram tên x, mang giá trị là 10
            //Hãy in ra giá trị vùng RAM/READ()/GET()
            //Sờ chạm tên biến là sờ chạm Value - GET()
            Console.WriteLine("x: " + x);//GetX(): được giá trị x
            //SỬA/ĐỔI VALUE - SET()
            x = 305;//SetX(305): ghi đè giá trị lên vùng RAM x
            Console.WriteLine("x again: " + x);//GetX(): đc x
        }
    }
}
