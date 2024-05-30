using StudentManagerV5.Entities;

namespace StudentManagerV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new();
            Student s2 = new("SE1", "An");
            //Git changes
        }
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