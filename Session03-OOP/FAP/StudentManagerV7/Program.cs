using StudentManagerV7.Entities;

namespace StudentManagerV7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("s1 default:");
            s1.ShowProfile();

            s1.Gpa = 9;
            s1.Id = "SE1";
            s1.Name = "An";
            s1.Yob = 2004;

            Console.WriteLine("s1 after setting:");
            s1.ShowProfile();
            //VIẾT TỰ NHIÊN HON8 SO VỚI s1.SetName("An");
            //Id, Name, Yob, Gpa: ĐƯỢC GỌI LÀ PROPERTY CỦA 1 OBJECT
            //CÒN _id, _name, _yob, _gpa nay gọi là "BACKING FIELD"
            //ĐỨA ĐỨNG SAU, CHỐNG LƯNG, HẬU TRƯỜNG CHO THẰNG GET/SET STYLE MỚI

            //CÁCH NEW VI DIỆU BẮT ĐẦU
            //PHỐI HỢP VỪA NEW VỪA SET LUÔN
            Student s2 = new Student() { Id = "SE2", Name = "Binh", Yob = 2004, Gpa = 9 };
            //Kỹ thuật new kiểu này(new xong rồi gán luôn bằng setter trên cùng 1 câu lệnh. Đừng nhầm với NAMED ARG - new trong ctor!!)OBJECT INITIALIZER
            s2.ShowProfile();
            //HỌC THÊM DC 2 CÁCH NEW MỚI: NAMED ARGUMENT, OBJECT INITIALIZER
            //TỔNG CỘNG 6 CÁCH:
            // <Class> obj = new <Class>();//NORMAL
            // <Class> obj = new(); //new gọn
            // var obj = new <Class>();//biến dùng var
            // <Class> obj = new <Class>(field1: value, field2: value,...);//NAMED ARGUMENTS
            // <Class> obj = new <Class>(){ prop1 = value, prop2 = value, ...};//OBJECT INITIALIZER
            // new <Class>();//Anonymous
        }
    }
}
