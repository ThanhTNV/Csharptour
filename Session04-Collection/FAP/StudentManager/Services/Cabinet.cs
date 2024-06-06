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
        
    }
}
