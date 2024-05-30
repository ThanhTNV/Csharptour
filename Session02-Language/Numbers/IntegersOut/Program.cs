using System.Collections.Concurrent;

namespace IntegersOut
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    ChangeXV1(x);
        //    Console.WriteLine($"After calling method, x = {x}");
        //}


        static void Main(string[] args)
        {
            //xài hàm out ra sao?
            //có ít nhất 3 cách
            //CÁCH 1: Khai báo biến và gán sẵn value, nhưng value sẽ bị đè sửa bởi bên trong hàm
            int n = 3979;
            Console.WriteLine($"Before calling out method, n = {n}");
            ChangeXV2(out n);
            Console.WriteLine($"After calling out method, n = {n}");
            
            //CÁCH 2: Khai báo biến, không thèm gán value cho biến vì đằng nào hàm out đã hứa sẽ có value;
            int x;
            //Console.WriteLine($"Before calling method, x = {x}");
            ChangeXV2(out x);
            Console.WriteLine($"After calling out method, x = {x}");

            //CÁCH 3: Cách này chatGPT và Copilot hay dùng, vừa khai báo biến vừa truyền vào out, đằng nào cũng dc value từ hàm ném ra
            ChangeXV2(out int xxx);
            Console.WriteLine($"After calling out method, xxx = {xxx}");
        }

        //Viết 1 hàm nhận vào 1 con số(Qua biến đầu vào), sau đó hàm thay đổi biến đầu vào này thành giá trị mới
        //Kỹ thuật truyền thống: Truyền tham trị - PASS BY VALUE
        //Copy data từ vị trí gốc sang hàm dc gọi
        //Hàm làm gì k biết, data gốc k bị thay đổi
        //PASS BY VALUE: TAO CHO MÀY BẢN COPY DATA, PHOTO RA 1 BẢN
        static void ChangeXV1(int number)
        {
            Console.WriteLine($"In method, n at first: {number}");
            number = 3979;
            Console.WriteLine($"In method, n after: {number}");
        }


        //Lúc xài hàm ChangeXV2() cần có biến đưa vào
        // int xxx = 20;
        //ChangeXV2(out xxx);
        static void ChangeXV2(out int number)
        {
            //out: hứa trong hàm sẽ có 1 value cho n. Phải gán 1 giá trị cho n, không thì sẽ báo lỗi - giữ lời hứa luôn có value nào đó!
            number = 6789;
        }
        //CHALLENGE #1: Viết 1 hàm trả về
        //Tổng các số từ 1..10
        //Tổng các số lẻ từ 1..10
        //Tổng các số chẵn từ 1..10
        //Số lượng các số lẻ từ 1..10
        //Số lượng các số chẵn từ 1..10
        //Số lượng các số nguyên tố 1..10

        //CHỈ 1 HÀM DUY NHẤT!!!
    }
}
