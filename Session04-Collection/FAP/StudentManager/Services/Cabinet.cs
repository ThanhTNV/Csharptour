using StudentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    //CÁI TỦ LÀ 1 THỨ (GIỐNG NHƯ FORM, TEMPLATE, KHUÔN) DÙNG ĐỂ LƯU TRỮ NHIỀU MÓN ĐỒ, NHIỀU INFO, INFO NÀY CHÍNH LÀ CÁC OBJECT
    //TA TẠO CLASS TỦ, ĐỂ TƯƠNG LAI TA NEW TỪNG CÁI TỦ, VÌ MỖI CÁI TỦ CHÍNH LÀ 1 OBJECT
    //ĐI MUA CÁI TỦ ĐI ~ new Tủ() - new Cabinet()
    //Mua tủ thì có được không gian lưu trữ, cất giữ nhiều món đồ
    //Nhiều món đồ -> cần mảng
    //ĐẶC TÍNH CỦA CÁI TỦ LÀ MẢNG, LÀ KHÔNG GIAN CHỨA TỦ
    //HÀNH ĐỘNG CỦA TỦ: CRUD MÓN ĐỒ(C - CREATE; R - RETRIEVE/READ; U - UPDATE; D - DELETE)
    internal class Cabinet
    {
        //private Student[] _arr;//có new ngay hay không? - Tùy bạn
        private Student[] _arr = new Student[30];
        private int _size = 0;//Tủ mới mua về thì chưa có món nào trong tủ
        public Cabinet()
        {

        }
        public Cabinet(int size)
        {
            _arr = new Student[size];//custom size tủ theo yêu cầu
        }
        public int Size => _size; //hàm Get() đó nhen, nhưng mà viết theo style PROP của C#
        //KHÔNG CÓ SET CHO BIẾN _count, vì nó ảnh hưởng đến đếm số object, hồ sơ trong mảng!! - BIẾN NỘI BỘ, KHÔNG CÓ NHU CẦU SHOW RA BÊN NGOÀI, CÙNG LẮM CÓ THÊM HÀM GET() ĐỂ BIẾT DUNG LƯỢNG TỦ HIỆN TẠI

        //TẠI SAO KHÔNG NÊN LÀM GET(), SET() CHO _arr?
        //TRẢ LỜI: GET() TRẢ VỀ MẢNG THÔ - CÓ SAO TRẢ VỀ VẬY => KHÔNG ỔN VỀ MẶT QUẢN LÝ DATA
        //         LẼ RA PHẢI TRẢ VỀ MỘT MẢNG ĐÃ ĐƯỢC XỬ LÝ= > LÀ 1 HÀM CÓ TÍNH TOÁN, CHỨ KHÔNG PHẢI GET THUẦN!!!
        //==> KHÔNG LÀM HÀM GET() LÀ HỢP LÝ

        //THEO LOGIC XỬ LÝ MẢNG, SẼ XỬ LÝ THEO TỪNG PHẦN TỬ.
        //SET() THÌ BẮT PHẢI ĐIỀU CHỈNH 1 LẦN CẢ 1 MẢNG, GÁN 1 LẦN NGUYÊN 1 MẢNG => PHI LOGIC, SAI TIÊU CHUẨN VỀ MẶT XỬ LÝ DATA
        //HÀM SET() NGHĨA LÀ: SET MẢNG, PHẢI CHUẨN BỊ 1 MẢNG CÓ 1 SỐ LƯỢNG SINH VIÊN
        //RỒI ĐẨY THẲNG 1 NHÁT VÀO MẢNG
        //arr = 1 mảng đã đủ, nhiều Student()
        //=> KHÔNG THỰC TẾ: TỦ HỒ SƠ PHẢI ĐƯỢC ADD TỪ TỪ!
        //SWP: THÊM MỚI 1 SẢN PHẨM TRONG 1 LẦN!!! ĐƠN HÀNG ĐẾN TỪ TỪ, GIỎ HÀNG CŨNG TỪ TỪ MỚI ĐẦY
        
        //TẠO MỚI NHIỀU SẢN PHẨM 1 LÚC: CHUẨN BỊ 1 DS EXCEL VÀ IMPORT


        //BỘ HÀM CRUD
        public void ShowList()
        {
            if(Size > 0) 
            {
                Console.WriteLine($"There is/are {Size} student(s). List of student: ");
                for (int i = 0; i < Size; i++)
                    _arr[i].ShowProfile();
            }
            else
            {
                Console.WriteLine("The list is empty. Nothing to print.");
            }
            
        }
        public void AddAStudent(Student student)
        {
            //ta phải có code để nhập info sinh viên ở đây thì mới new được chứ
            //nhập:
            //  từ console.readline() => trả về chuỗi => cần số thì convert từ chuỗi về
            //HÀM NÀY CHỈ CHƠI VỚI APP CONSOLE -> KÉM LINH HOẠT!!
            //VÌ VIỆC NHẬP INFO CÓ THỂ ĐẾN TỪ WEB, WINFORMS(UI DESKTOP), MOBILE
            //ĐỂ ĐẢM BẢO TÍNH LINH HOẠT, ĐỪNG GẮN VIỆC INPUT VÀO CLASS NÀY, CLASS NÀY CHỈ LO XỬ LÝ INFO, NHẬP ĐỂ NƠI KHÁC TRUYỀN SANG
            if(Size == 30)
            {
                throw new Exception("The list is full. No more student profile added");
            }
            else
            {
                _arr[Size] = student;
                _size++;
            }
        }
        public void AddAStudent(string id, string name, int yob, double gpa) 
        {
            if(Size == 30)
            {
                throw new Exception("The list is full. No more student profile added");
            }
            else
            {
                _arr[Size] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
                _size++;
            }
        }
        //HÀM SỐ 1 LINH HOẠT HƠN HÀM SỐ 2, VÌ KHÔNG YÊU CẦU PHẢI TẠO SINH VIÊN THEO 1 CONSTRUCTOR NHẤT ĐỊNH

        public void RemoveAStudent(Student student)
        {
            for (int i = 0;i < Size; i++)
            {

            }
        }
    }
}

//NHIỀU HÀM TRÙNG TÊN NHAU, NHƯNG KHÁC THAM SỐ - KHÁC TRÊN DATATYPE
//ĐC GỌI LÀ OVERLOAD, OVERLOADING
//OVERLOAD LÀ 1 DẠNG THỂ HIỆN CỦA NGUYÊN LÍ ĐA HÌNH - POLYMORPHISM