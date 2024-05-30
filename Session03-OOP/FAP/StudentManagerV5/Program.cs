using StudentManagerV5.Entities;
using System.Runtime.Intrinsics.Arm;

namespace StudentManagerV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("s1 at first(default):");
            Console.WriteLine(s1); //autocall toString
            s1.SetName("An");
            s1.SetId("SE1");
            Console.WriteLine("s1 after set()");
            Console.WriteLine(s1);

            Student s2 = new("SE2", "Binh", 2004, 8.6);
            Console.WriteLine("s2 full info:");
            Console.WriteLine(s2);

            var s3 = new Student(name: "Cuong", yob: 2004, gpa: 8.7, id: "SE3");
            //Kĩ thuật truyền value vào hàm, vào constructor nhưng không theo thứ tự khai báo biến của tên hàm, mà đảo thứ tự thoải mái, miễn là ghi chú thêm tên biến đầu vào + ":"
            //Giúp bạn truyền tham số theo cách bạn muốn, thứ tự bạn muốn mà ko gây báo lỗi tương thích tham số
            //NAMED ARGUMENT: TRUYỀN THAM SỐ ĐI KÈM TÊN THAM SỐ
            //INSERT INTO ACCOUNT VALUES(THEO ĐÚNG THỨ TỰ CỘT TRONG DB)
            //NHƯNG VỚI NAMED ARGUMENT, NÓ SẼ TƯƠNG ĐƯƠNG VỚI:
            //      INSERT INTO ACCOUNT(EMAIL, PHONE, ID) VALUES(...)
            Console.WriteLine("s3 full info(Using Named Argument):");
            Console.WriteLine(s3);

            //OBJECT VÔ DANH/ANONYMOUS OBJECT
            Student s4 = new Student("SE4", "Dung", 2004, 8.8);
            //  pointer            object/vùng RAM HEAP

            //s4 + '.': vào vùng RAM new xem có gì public, có gì gọi ra được
            //s4 chính là tay cầm
            //vùng new RAM là con diều
            //s4 nối thẳng tới vùng new thông qua địa chỉ aka tay cầm sợi dây giữ con diều
            Console.WriteLine("s4 show profile:");
            s4.ShowProfile();


            Console.WriteLine("Object vô danh:");
            new Student("SE0", "Anonymous", 2004, 8.8).ShowProfile();
            //OBJECT ĐƯỢC TẠO RA NHƯNG KHÔNG BỊ BIẾN NÀO TRỎ VÀO
            //NHƯ CON DIỀU BAY LÊN MÀ KHÔNG CÓ SỢI DÂY GIỮ LẠI
            //OBJECT MÀ KHÔNG ĐƯỢC ĐẶT TÊN, GÁN BIẾN TRỎ, GỌI LÀ OBJECT VÔ DANH ANONYMOUS OBJECT
            //MÁY ẢO JAVA(JVM), .NET RUNTIME ĐỊNH KỲ QUÉT VÙNG RAM COI CÓ ĐỨA NÀO TRÔI NỔI, KHÔNG CÓ CON TRỎ MÓC VÀO, KHÔNG CÓ AI QUẢN LÝ, NẮM GIỮ, THÌ BỊ CLEAR KHỎI RAM
            //ĐOẠN CODE RUNTIME TRONG RAM DỌN DẸP BỘ NHỚ GỌI LÀ GARBAGE COLLECTOR - NGƯỜI DỌN RÁC

            //ÁP DỤNG LÀM SAO??
            //Random rd = new Random();
            //double n = rd.nextDouble();

            //Thay vì giữ thằng rd mà không xài lại
            //double n = new Random().nextDouble();


            Student s5 = s2; //SE2 | Binh | 2004 | 8.6
            PassAStudent(s2);
            Console.WriteLine("s2 sau khi gọi hàm PassAStudent(s2)");
            s2.ShowProfile();
        }

        //HÀM KHÁC NGOÀI MAIN NHƯNG TRONG CLASS
        static void PassAStudent(Student x)
        {
            x.SetName("THÍCH TỰ DO");
            //TRUYỀN 1 OBJECT VÀO HÀM, CHÍNH LÀ TRUYỀN ĐỊA CHỈ VÙNG NEW BÊN NGOÀI VÀO TRONG HÀM - CHÍNH LÀ TRUYỀN THAM CHIẾU
            //VÌ TRONG HÀM MÀ SET() GÌ THÌ VÙNG NEW BÊN NGOÀI CŨNG BỊ THAY ĐỔI
            //HÀM NHẬN VÀO BIẾN OBJECT CHÍNH LÀ TRUYỀN THAM CHIẾU, TRONG HÀM CÓ THỂ THAY ĐỔI BỞI VÙNG NEW BÊN NGOÀI - KHÔNG CẦN REF, OUT
            //<3 TỐNG PHƯỚC QUAN
        }

        //3 cách new object
        //<Class> obj1 = new <Class>Constructor();
        //<Class> obj1 = new Constructor();
        //var obj1 = new <Class>Constructor();
    }
}


//LẬP TRÌNH OOP - OBJECT ORIENTED PROGRAMMING/PARADIGM
//LẬP TRÌNH DỰA TRÊN LÀM VIỆC VỚI CÁC OBJECT
//OBJECT LÀ GÌ?
//LÀ NHỮNG THỨ CỤ THỂ QUANH TA MÀ MÔ TẢ BẰNG NHỮNG CÂU TỪ DÀI
//MÔ TẢ QUA 2 THỨ, 2 GÓC NHÌN
//1. GÓC NHÌN TĨNH - STATE - ĐẶC ĐIỂM
//      ID, NAME, YOB, GPA, SALARY, WORKING HOUR,...
//2. GÓC NHÌN ĐỘNG - BEHAVIOR - METHOD - FUNCTION
//      TÍNH LƯƠNG(), TÍNH SỐ NGÀY NGHỈ(), TÍNH TUỔI(), TÍNH BILL()
//>>>>>>>>CÔNG THỨC LẬP TRÌNH OOP
//1. NHẬN DIỆN XUNG QUANH BÀI TOÁN CÁC OBJECT (ĐẶC ĐIỂM VÀ HÀNH VI)
//2. PHÂN LOẠI, GOM NHÓM, CHIA NHÓM, ĐẶT TÊN NHÓM THEO NHỮNG OBJECT MÀ CÓ NHIỀU ĐẶC ĐIỂM TƯƠNG ĐỒNG (CLASSIFY - CHIA NHÓM THÀNH CÁC NHÓM/CLASS)
//      NHÓM CLASS STUDENT, LECTURER, HUMAN, PET, STAFF, CUSTOMER, MANAGER,...
//      TẠO CLASS (ĐẠI DIỆN CHO 1 ĐÁM OBJECT)
//          ĐẶC ĐIỂM:
//              ID:     ____________
//              NAME:   ____________
//              YOB:    ____________
//              ....
//      CLASS NHƯ 1 TEMPLATE, BLUEPRINT, FORM, BIỂU MẪU, KHUÔN,... DÙNG ĐỂ ĐÚC RA, NHÂN BẢN RA CÁC OBJECT
//3. MỖI FORM, TEMPLATE, KHUÔN CẦN ĐƯỢC LÔI RA, CLONE, ĐỔ MỰC/NGUYÊN LIỆU/ĐIỀN INFO ĐỂ NHÂN BẢN RA OBJECT. HÀNH ĐỘNG NÀY CHÍNH LÀ ỨNG VỚI HÀM CONSTRUCTOR
//  ỨNG VỚI HÀNH ĐỘNG ĐIỀN VÀO FORM...
//  TẠO CONSTRUCTOR LÀ BƯỚC SỐ 3
//4. KHI TA ĐIỀN XONG CÁI FORM, CÁI TEMPLATE, CẦM LÊN
//   TA NHÌN VÀO TỪNG FIELD CỦA FORM   >>>>>>> GET() VIEW() SEE()
//   TA THẤY CÓ 1 FIELD KHÔNG ĐÚNG, TA XÓA, GHI ĐÈ LÊN ĐỂ SỬA >>>>>>>>>> SET() SETTING() SETTER()
//5. KHI TA TẠO XONG 1 ACCOUNT TRÊN MẠNG XÃ HỘI, TA SẼ SHOW PROFILE CỦA MÌNH RA CHO BÀN DÂN THIÊN HẠ XEM
//   KHI XUẤT XƯỞNG CON ĐIỆN THOẠI, NGTA ĐỂ KÈM 1 CÁI HƯỚNG DẪN SỬ DỤNG, THÔNG TIN CẤU HÌNH CỦA CON ĐIỆN THOẠI
// KHOE INFO CỦA 1 OBJECT >>>>>>> TOSTRING()

// VẬY LẬP TRÌNH OOP LÀ TẠO CLASS, LẬP TRÌNH TRÊN TEMPLATE, FORM, CHUNG CHUNG NHẤT
//Y CHANG NHƯ GIẢI ĐỀ TOÁN, CÓ CÁI KHUNG CÔNG THỨC -> RÁP SỐ LIỆU VÀO ĐỂ RA KẾT QUẢ BÀI TOÁN YÊU CẦU
//TỪ OBJECT RA ĐƯỢC CLASS -> TỪ CLASS NHÂN BẢN LẠI CÁC OBJECT CÙNG NHÓM - KĨ THUẬT QUẢN LÝ INFO QUA OOP
//6. CLONE OBJECT TỪ KHUÔN, NEW OBJECT, NEW CÁI FORM, NEW BỨC TƯỢNG TỪ KHUÔN
//   TOÁN TỬ NEW GIỐNG NHƯ PHOTOCOPY LẠI 1 CÁI FORM MỚI, ĐIỀN INFO VÀO RIÊNG CỦA MÌNH -> OBJECT