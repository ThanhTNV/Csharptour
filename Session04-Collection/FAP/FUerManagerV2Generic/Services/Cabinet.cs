using FUerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManagerV2Generic.Services
{
    //HIỆN ĐẠI: DATATYPE ĐƯỢC QUYỀN THAY ĐỔI, GIỐNG NHƯ THAM SỐ HÀM
    //HÀM BÂY GIỜ CHẤP NHẬN ĐẦU VÀO/THAM SỐ ĐẦU VÀO CÓ 2 SỰ THAY ĐỔI
    //void F(???? biến)
    //          có thể là bất kì datatype nào đó
    //sau khi xđ dc datatype, ta mới xác định tiếp giá trị của biến thuộc datatype đó

    //void F(Student biến)
    //void F(Lecturer biến)
    //KỸ THUẬT TRUYỀN VÀO 1 DATATYPE, DATA TYPE DC TRUYỀN VÀO 1 HÀM, 1 CLASS(ĐỂ XĐ CLASS SẼ LÀM VIỆC VỚI DATATYPE NÀO)
    // DATATYPE LÀ THAM SỐ LUÔN => KỸ THUẬT NÀY ĐC GỌI LÀ GENERIC
    //XÀI KÝ TỰ <DATATYPE MUỐN TRUYỀN>
    //KHIẾN HÀM VÀ CLASS CHƠI DC VỚI NHIỀU LOẠI DATATYPE

    //generic repo & unit of work
    //DESIGN PATTERN => 1 KHUÔN MÃU, 1 CÁCH THIẾT KẾ CLASS/CODE
    public class Cabinet<T>//T - Type
                           //hãy đưa kiểu dữ liệu vào đi: Student, Lecturer, Lion, Tiger, Dog, Cat,...
                           //Lần đầu tiên datatype được xem là 1 tham số
                           //Class có thể làm việc với nhiều loại datatype khác nhau
                           //-> <> Gọi là GENERIC
                           //T LÀ 1 BIẾN, MÀ VALUE CỦA NÓ LÀ DATATYPE
    {
        private T[] _arr;
        private int _count = 0;
        public int Count { get; }
        public Cabinet(int size) 
        { 
            _arr = new T[size];
        }
        public void Print()
        {
            Console.WriteLine($"There is/are {_count} item(s) in the cabinet");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i].ToString());
            }
        }
        public void Add(T item) 
        {
            _arr[_count] = item;
            _count++;
        }
    }
}
//CÁCH XÀI CABINET<STUDENT>
//         CABINET<lECTURER> //DATA TYPE DC ĐƯA VÀO NHƯ 1 THAM SỐ, DATA TYPE LÀ VALUE
//NGHE CÁI MÙI QUEN QUEN, LIST<STUDENT> CỦA JAVA

//BÌNH LUẬN
//GENERIC TUYỆT VỜI KHI GIÚP CLASS CHÚNG TA LÀM VIỆC ĐC VỚI NHIỀU CLASS KHACS BÊN TRONG NÓ, CLASS CABINET CÓ THỂ LÀM VIỆC VỚI, XỬ LÍ CÁC OBJECT, MẢNG OBJECT CỦA NHIỀU LOẠI DATATYPE KHÁC

//TUY NHIÊN NÓ CHƠI VỚI MẢNG, VÀ MẢNG THÌ DỄ DUGN2, NHƯNG KO LINH HOẠT
//MẢNG: FIXED SIZE - MẢNG LÀ KHAI BÁO NHIỀU BIẾN, NHƯNG PHẢI CHỈ RA BAO NHIÊU BIẾN
//      MỘT KHI ĐÃ CHỈ BAO NHIÊU THÌ CHỈ CÓ BẤY NHIÊU, KO XIN THÊM
//      NẾU MUỐN XIN THÊM, XIN MẢNG MỚI BỰ HƠN, COPY MẢNG CŨ QUA
//MẢNG THÌ PHẢI ĐI KÈM COUNT! ĐỂ ĐẾM SỐ PHẦN TỬ ĐÃ CÓ VALUE
//VÀ COLLECTION XUẤT HIỆN: LIST, ARRAYLIST, SET, MAP
//ĐÂY LÀ NHỮNG MẢNG CO DÃN KÍCH THƯỚC SỐ PHẦN TỬ
//VÙNG NEW MÀ CÓ THỂ NỞ THÊM!
//CẦN THÊM THÌ CHO THÊM, CẦN BỚT THÌ BỚT LUÔN
//VÀ CHÚNG NÓ CÓ CHƠI VỚI GENERIC, VÙNG NEW LIST<> CÓ CHƠI GENERIC, CHỨA NHIỀU OBJECT CỦA CÁC CLASS KHÁC NHAU!!
