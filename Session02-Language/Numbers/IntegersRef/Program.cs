namespace IntegersRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6868;
            ChangeX(ref x);
            Console.WriteLine("x = " + x);
        }

        static void ChangeX(ref int x)
        {
            x += 21 - 100;
        }
    }
}

//IN OUT REF: 3 THẰNG DÍNH TỚI THAM SỐ ĐẦU VÀO
//OUT VÀ REF GIỐNG NHAU 99%: TRONG HÀM THAY ĐỔI THÌ BÊN NGOÀI ĐỔI THEO(TRUYỀN THAM CHIẾU - PASS BY REFERENCE)
//  OUT: Hứa chắc kèo, chắc chắn phải có 1 giá trị trả về trong hàm
//  REF: Tao không hứa, có thể có hoặc có thể không
//       Xài ref bắt buộc phải gán value cho biến trước đã, phòng hờ ref không làm gì cả
//       Sau gọi hàm vẫn có Value
//NHA SĨ KHUYÊN DÙNG:
//  DÙNG OUT HAY HƠN, TIỆN DỤNG HƠN, TỰ NHIÊN HƠN, DO LUÔN HỨA TRẢ VỀ GIÁ TRỊ, KO CẦN GIÁ TRỊ KHỞI ĐẦU CHO BIẾN HỨNG VALUE
//HÀM LUÔN PHẢI TRẢ VALUE THÌ MỚI HỢP LOGIC

//BUỔI SAU: BOXING, UNBOXING, CLASS, GENERIC, DELEGATE -> ANONYMOUS METHOD -> LAMBDA EXP -> LINQ -> EF CORE DB
//ĐI VÀO PE