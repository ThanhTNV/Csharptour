namespace Integers
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Challenge1();//PrintNumbersFrom1To100
        //    //Challenge2();//PrintEvenNumbersFrom1To100
        //    //Challenge3(100);//PrintNumbersFrom1ToN
        //    Console.WriteLine($"Sum even from 1 to 10: {Challenge4()}");
        //    /*
        //    var res = Challenge4();
        //    Console.WriteLine($"Sum even from 1 to 10: {res}");//interpolation
        //    Console.WriteLine("Sum even from 1 to 10: {0}", res);//placeholder
        //    Console.WriteLine("Sum even from 1 to 10: " + res);//String concat
        //    Console.WriteLine(@$"Sum even from 1 to 10: {res}");

        //    string msg = $"Sum even from 1 to 10: {res}";//Gán chuỗi để in
        //    Console.WriteLine(msg);
        //    Console.WriteLine($"Căn bậc 2 của 100: {Math.Sqrt(100)}");*/

        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Sum odd from 1..10: " + Challenge5());

        }

        //C# hỗ trợ các kiểu dữ liệu số nguyên y chang Java: int, long,...
        //C# cũng hỗ trợ các cấu trúc câu lệnh y chang Java: if, if else, switch case, do while, while, for,...

        //CHALLENGE #1: HÃY VIẾT 1 HÀM IN RA CÁC SỐ TỰ NHIÊN TỪ 1 ĐẾN 100
        static void Challenge1()
        {
            Console.WriteLine("The list of numbers from 1 to 100:");
            //for (int i = 0; i < 101; i++)
            //{
            //    Console.Write(i + " ");
            //}

            for (int i = 1; i < 101; i++)
            {
                //Console.WriteLine(i + " ");
                //Console.Write("{0} ", i);
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();//sống có trách nhiệm, in xong xuống hàng, tránh ảnh hưởng hàm phía sau
        }
    
        //CHALLENGE #2: VIẾT HÀM IN RA CÁC SỐ CHẴN TỪ 1 ĐẾN 100
        static void Challenge2()
        {
            Console.WriteLine("The list of even numbers from 1..100:");
            for (int i = 1; i < 101; i++)
                if (i % 2 == 0)
                {
                    //Console.Write("{0} ", i);
                    Console.Write($"{i} ");
                }
            Console.WriteLine();//Sống có trách nhiệm
        }
        
        //CHALLENGE #3: VIẾT HÀM IN RA CÁC SỐ TỪ 1 ĐẾN N
        //bữa sau học: VAR, OUT, REF, OOP
        static void Challenge3(in int n)
        {
            /*
                n: local variable
                in(keyword): đưa vào ở tham số, biến tham số thành READ-ONLY, để đảm bảo code luôn xử lý đúng tham số đầu vào
            */
            //n = 5000;
            Console.WriteLine($"The list of numbers from 1..{n}");
            for (int i = 1; i < n+1; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();//sống có trách nhiệm
        }

        //CHALLENGE #4: VIẾT HÀM TÍNH TỔNG CỦA CÁC SỐ CHẴN TỪ 1 ĐẾN 100
        //HÀM VIẾT RA SAO KHÔNG CẦN BIẾT, CHĨ CẦN BIẾT NÓ PHẢI TRẢ VỀ HOẶC IN RA 30 - EXPECTED VALUE
        //HY VỌNG HÀM TRẢ VỀ 30 - EXPECTED VALUE
        //CÒN THỰC TẾ LÚC CHẠY HÀM LÀ BAO NHIÊU, THÌ GIÁ TRỊ TRẢ VỀ CỦA HÀM ĐƯỢC GỌI LÀ ACTUAL VALUE
        //NẾU ACTUAL == EXPECTED => HÀM NGON!
        //Unit Test trong môn SWT301
        static int Challenge4()
        {
            //int sum = 0;
            var sum = 0;
            //Kĩ thuật ko chỉ rõ tường minh datatype của biến, mà datatype của biến sẽ dc suy luận từ giá trị gán vào , gán ngay lúc khai báo
            //type inferent: Suy luận ngầm kiểu datatype của biến
            //xài var bắt buộc phải gán giá trị khởi đầu
            for (int i = 1; i <= 10; i++)
                if(i % 2 == 0)
                   sum += i;
            return sum;
        }

        //CHALLENGE #5: VIẾT HÀM TÍNH TỔNG CÁC SỐ LẺ TỪ 1..10
        //EXPECTED VALUE: 1 3 5 7 9 = 25
        //ACTUAL        : CHỜ CHẠY HÀM ĐÃ
        static int Challenge5()
        {
            var sumOdd = 0;
            for (int i = 1; i <= 10; i++)
                if(i % 2 != 0) 
                    sumOdd += i;
            return sumOdd;
        }

        //CHALLENGE #6: 
        //SQL: SELECT SUM(), COUNT(), AVG(),...
        //     FROM ...
        //     WHERE ...
        //     GROUP BY ...
        //     HAVING ...
        //LỠ 1 LẦN ĐI QUA TẬP DATA, TÍNH LUÔN NHIỀU GIÁ TRỊ!!!
        //HÀM TRONG JAVA, C, C# NÓI CHUNG CHỈ TRẢ VỀ 1 GIÁ TRỊ
        //VẬY CÓ CÁCH NÀO ĐỂ GIÚP HÀM TRẢ VỀ NHIỀU GIÁ TRỊ HAY KHÔNG KHI CHỈ GỌI HÀM 1 LẦN, GIỐNG SELECT GỘP NHIỀU HÀM
        //CÓ!!!!: OUT VÀ REF
        

    }
}

//CHALLENGE AT HOME
//KEYWORD "IN" BIẾN THAM SỐ ĐẦU VÀO THÀNH READ-ONLY, VÀ NÓ CÓ THỂ ÁP DỤNG CHO BIẾN PRIMITIVE VÀ BIẾN OBJ, HAY GỌI LÀ ÁP DỤNG CHO TRUYỀN THAM TRỊ VÀ TRUYỀN THAM CHIẾU
//"IN" BIẾN ĐỔI THAM SỐ THÀNH READ-ONLY, TỨC LÀ KHÔNG CHO THAY ĐỔI GÁI TRỊ TRUYỀN VÀO HÀM
//VẬY f(in int n) thì n không cho đổi value?
//Vậy f2(in Student x) thì x READ-ONLY như thế nào? Được thay đổi và không thay đồi cụ thể như thế nào
//x là Student, nó phức tạp hơn int x