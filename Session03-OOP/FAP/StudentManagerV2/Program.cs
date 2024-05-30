using StudentManagerV2.Entities;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new("SE1", "An", 2004, 8.6);
            Console.WriteLine("s1 details: {0}", s1);

            Student s2 = new Student("SE2", "Binh");
            Console.WriteLine("s2 details: {0}", s2);
            //Nếu biến cục bộ (Biến khai báo trong hàm) mà không gán giá trị thì cấm sử dụng ở các lệnh tiếp đó
            //Còn nếu field của object mà không dc gán value lúc đúc/new thì sẽ mang giá trị DEFAULT(thường với number là 0, với string là "", với bool là FALSE)
            //Để đảm bảo các hàm bên trong object không vi phạm nguyên lý, vẫn sử dụng dc biến bình thường vì đã có value
            //để sửa dc những value DEFAULT này thì ta đổ value mới cho nó --> Gọi SETTER đưa Data mới đè vào Data cũ
            s2.SetYob(2002);
            s2.SetYob(2003);
            s2.SetYob(2004);
            s2.SetGpa(8.8);
            Console.WriteLine("s2 details after setting yob and gpa: {0}", s2);

            //một vùng new SE2 Binh có thể dc chỉnh sửa info thoải mái số lần
            //NGHĨA LÀ HÀM SET CÓ QUYỀN GỌI NHIỀU LẦN VÀ VẪN LÀ OBJECT ĐÓ, VẪN VÙNG NEW ĐÓ
            //NHƯNG
            s2 = new Student("SE22", "Hai Hai");
            Console.WriteLine("s2 again after new: {0}", s2);

            //khi dùng new là lập tức có vùng RAM mới
            //new là gọi phễu để đúc ra obj mới
            //.set() có thể gọi n lần ứng với việc mình thay đổi hình nền đth
            //dù có chỉnh sửa bao nhiêu lần thì vẫn trên 1 cái đth cũ
            //còn new là sử dụng 1 cái đth mới hoàn toàn
            //new: Tạo mới 1 object hoàn toàn
            //set: thay đổi trên object cũ
        }
    }
}
