using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Services
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
    internal class Cabinet
    {
        
    }
}
