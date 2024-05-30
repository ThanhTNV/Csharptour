using MainUI.Lyrics;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAge();
            //PrintLyricOrPoem();
            //UseVerbatim();
            //LyricLibrary.PrintChungTaCuaTuongLai
        }

        //OOP: Static chơi với static
        static void PrintLyricOrPoem()
        {
            //Console.WriteLine(
            //    "Từ ấy trong tôi bừng nắng hạ\n" +
            //    "Mặt trời chân lý chói qua tim\n" +
            //    "Hồn tôi là một vườn hoa lá\n" +
            //    "Rất rộn hương và rộn tiếng chim");

            Console.WriteLine(@"
Từ ấy trong tôi bừng nắng hạ
Mặt trời chân lý chói qua tim
Hồn tôi là một vườn hoa lá
Rất rộn hương và rộn tiếng chim

Từng là duy nhất mối tình bình yên đối với anh
Từng là những nắm tay mềm thật ấm đối với anh
Từng là cảm xúc nhớ nhiều về đêm đối với anh
Từng là em

Từng là những tháng năm dài mình chung bước bên nhau
Từng là những nắng ban chiều mà anh bước theo sau
Từng là tất cả những gì đời mang đến cho ta
Giờ đã quá xa

<html>
    <body>
        <div>
        
        </div>
    </body>
</html>
");
            //Ctrl+K+C: Comment , Ctrl+K+U: Un-comment: Mở/đóng ghi chú
            //Đối với Java là Ctrl+/
        }//raw string: chuỗi nguyên bản, có gì in nấy, tắt chức năng tất cả ký tự đặc biệt có trong chuỗi, trở lại thành ký tự bình thường, \n không còn là xuống hàng.
        //Kỹ thuật gọi là VERBATIM(Java có luôn)
        //DÙNG VERBATIM ĐỂ LÀM GÌ?
        //Để lưu 1 đoạn văn bản theo đúng nguyên bản.
        //Trong windows dùng để gán đường dẫn tập tin trong windows, ko bị lỗi String khi gán
        //Trong chuỗi kết nối csdl, khi tên server có dấu "//" hay "\\"
        static void UseVerbatim()
        {
            //string filePath = "C:\\news";
            string filePath = @"C:\news"; //verbatim để dùng chuỗi nguyên bản rất tự nhiên, \n là \n chứ ko phải xuống hàng
            //Kết hợp với Interpolation $
            Console.WriteLine(filePath);
            Console.WriteLine(@$"Your path: {filePath}\n\n");
        }

        static void GetAge()
        {
            int yob = 2004;//Biến local(Khai báo trong hàm) thì khai báo theo cú pháp con lạc đà - camelCase, ex: salary, radius, basicSalary

            int age = 2024 - yob;
            
            Console.WriteLine("Yob: " + yob + " | Age: " + age);
            //cw + Tab <=> sout + Tab(Java)
            Console.WriteLine("Yob: {0} | Age: {1}", yob, age);
            //Kỹ thuật placeholder: Đằng trước là thứ tự của biến(Tính từ 0), đằng sau(sau dấu ",") là danh sách biến
            //Giống như %d trong C
            Console.WriteLine($"Yob: {yob} | Age: {age}");
            //Kỹ thuật Interpolation: Tự suy luận đâu là biến, đâu là ký tự, để điền giá trị của biến vào chuỗi
        }
    }
}
