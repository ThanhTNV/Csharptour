using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //Nếu 1 cái khuôn không làm cái phễu thì ta vẫn đúc được 1 object mang không khí bên trong(Tức là mang giá trị DEFAULT) => VẪN CÓ ĐƯỢC OBJECT
        //ĐỐI VỚI JAVA C#, NẾU BẠN KHÔNG LÀM CONSTRUCTOR ĐỂ ĐÚC OBJECT THÌ JAVA C# SẼ CUNG CẤP SẴN 1 CÁI PHỄU RỖNG - KHÔNG NHẬN ĐẦU VÀO VÀ CŨNG CHẲNG XỬ LÝ GÌ CẢ
        //=>CONSTRUCTOR DEFAULT
        //Có dạng public Student(){}
        //BẠN DÙNG NÓ ĐỂ new NHƯ BÌNH THƯỜNG SẼ TẠO RA 1 VÙNG new CHỨA TOÀN INFO DEFAULT NHƯNG VẪN LÀ OBJECT
        //y chang ngoài đời, bạn mua 1 căn nhà thô, bạn photo 1 tờ form điền - new rồi nhưng chưa có dữ liệu, thông tin, giá trị, từ từ điền vào sau
        //nhưng bản chất vẫn là có nhà, có form, có OBJECT
        public void ShowProfile()
        {
            Console.WriteLine($"profile using show profile: {ToString()}");
        }
        public override string ToString()
        {
            return $"{_id} | {_name} | {_yob} | {_gpa}";
        }
    }
}
