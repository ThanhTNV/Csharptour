using StudentManagerV4.Entities;

namespace StudentManagerV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new("SE1", "An");
            //Nếu class không có constructor thì Java C# sẽ tự sinh ra cho mình 1 constructor default/rỗng để giúp ta clone 1 vùng RAM chứa object toàn là default data
            //Giống như mình đi xin 1 cái form để dành điền sau
            //nếu đã có 1 constructor có tham số, hoặc nhiều constructor, thì Java C# không sinh ra constructor default
            //Lý do: Cần constructor để đúc object, mà bây giờ có rồi thì không cần sinh ra nữa
            //NHƯNG...
            //EM THÍCH LÀM CONSTRUCTOR RỖNG 1 CÁCH CHỦ ĐỘNG - EXPLICIT(TƯỜNG MINH, RÕ RÀNG)


        }
    }
}
