using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Numerics;

namespace NullValue
{
    internal class Student
    {
        //C# gợi ý cách viết code phần cơ bản cực nhanh gọn, học sau!!!
        //quay lại truyền thống
        //class gồm field + hàm/method => members - thành viên của 1 class
        //Encapsulation
        private string _id;//Con lạc đà và gạch chân từ đầu tiên
        public string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        
        public void showProfile()
        {
            Console.WriteLine($"ID: {_id} | Name: {_name} | YOB: {_yob} | GPA: {_gpa}");
        }
        
        //GETTER
        //public string getId()
        //{
        //    return _id;
        //}
        //public string getName()
        //{
        //    return _name;
        //}
        //public int getYob()
        //{
        //    return _yob;
        //}
        //public double getGpa()
        //{
        //    return _gpa;
        //}

        //SETTER
        //public void setId(String id)
        //{
        //    _id = id;
        //}
        //public void setName(String name)
        //{
        //    _name = name;
        //}
        //public void setYob(int yob)
        //{
        //    _yob = yob;
        //}
        //public void setGpa(ref double gpa)
        //{
        //    _gpa = gpa;
        //}
    }

    internal class StudentNull
    {
        //C# gợi ý cách viết code phần cơ bản cực nhanh gọn, học sau!!!
        //quay lại truyền thống
        //class gồm field + hàm/method => members - thành viên của 1 class
        //Encapsulation
        private string _id;//Con lạc đà và gạch chân từ đầu tiên
        public string _name;
        private int _yob;
        private double? _gpa;

        public StudentNull(string id, string name, int yob, double? gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public void showProfile()
        {
            Console.WriteLine($"ID: {_id} | Name: {_name} | YOB: {_yob} | GPA: {_gpa}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateStudentObjects();
            //PlayWithNullable();
            //PlayWithNullV1();
            //PlayWithNullV2();
            //PlayWithNullV3();
            //PlayWithNullV4();
            PlayWithNullableV2();
        }

        static void PlayWithNullableV2()
        {
            int a = 0;
            //int b = null;//BỊ CHỬI NGAY LÚC GÕ CODE VÌ LÝ DO
            //ĐÂY LÀ BIẾN PRIMITIVE(JAVA)
            //LÀ BIẾN, VÙNG RAM LƯU 1 GIÁ TRỊ ĐƠN LẺ NÀO ĐÓ NHƯ LÀ SỐ, KÝ TỰ: int, long, float, double, char
            //Biến style đơn giản này phải được gán 1 giá trị hợp lệ, không cho NULL

            int? c = 0;//Vẫn int bình thường nhưng có thể mang thêm giá trị null để match với trạng thái giá trị NULL trong database
            c = null;
            //? ?? y chang như đã học với biến obj/ref
            int b = c ?? 6;
            //int d = (c is not null ? c : b);//Ko chuyển int? thành int được

            Student s1 = null;
            Student? s2 = null;
            //Với kiểu dữ liệu class/object
            //mặc nhiên là dc dùng null mô tả trạng thái biến chưa trỏ vào ai
            //chưa xác định - dùng kết quả trả về search

            //Dùng thêm ? cũng chả ảnh hưởng
            //? đi kèm với DATA TYPE được gọi là: NULLABLE - Em có khả năng chứa giá trị null
            //Áp dụng chung cho cả 2 kiểu Primitive và Object

        }

        //static void PlayWithNullV4()
        //{
        //    Student s1 = null;
        //    Student s2 ??= new Student("SE2", "nhi", 2002, 2.2);
        //}

        static void PlayWithNullV3()
        {
            int yob = 2004;
            //nếu năm sinh > 2000 thì in ra GENZ
            //ngược lại thì in ra: Outdate
            string msg;
            //if (yob > 2000)
            //{
            //    msg = "GENZ";
            //}
            //else
            //{
            //    msg = "Outdate";
            //}
            
            msg = yob > 2000 ? "GENZ" : "Outdate";
            //Toán tử 3 ngôi - if else gộp: CONDITIONAL TERNARY OPERATOR
            Console.WriteLine(msg);
            //MỆNH ĐỀ ĐÚNG SAI TRONG PHÉP TOÁN NÀY KHÔNG HẲN LÀ CHECK NULL MÀ LÀ BẤT KÌ MỆNH ĐỀ SO SÁNH NÀO
            //CHỈ CẦN ĐÚNG SAI, KHÔNG CẦN CÓ  ĐÚNG NULL KHÔNG
            //NẾU MUỐN SO SÁNH NULL CŨNG ĐƯỢC NHƯNG CÓ THỂ DÙNG "NULL COALESING" CHO NÓ TIỆN, NGẮN GỌN
            Console.WriteLine("Checking s2..");
            Student s1 = null;
            //Student s2 = (s1 is null ? new Student("SE2", "Nhi", 2002, 2.2) : s1);
            Student s2 = s1 ?? new Student("SE2", "Nhi", 2002, 2.2);
            //ĐÉO khác gì nhau, nhưng mà cái thứ 2 chuyên dùng trị null, ngắn gọn xúc tích hơn
            s2.showProfile();
        }

        static void PlayWithNullV2()
        {
            Student s1 = null;

            Student s2 = s1;

            Student s3 = null;

            Student s4 = s3 ?? new Student("SE4", "Tư", 2004, 4.4);
            //"??" tương đương với
            //if (s3 is null) new Student("SE4", "Tư", 2004, 4.4);
            //else s4 = s3;
            //một dạng toán tử 3 ngôi - phiên bản chơi với NULL của C#
            //Kỹ thuật này đảm bảo rằng biến sẽ luôn được gán giá trị nào đó
            //Kỹ thuật này dùng để gán giá trị DEFAULT cho 1 biến nếu vế đầu tiên có thể mang giá trị NULL
            //s4 = s3 ?? null;
            //Nếu để cả 2 vế NULL thì ngta chửi mình ngu
            //TOÁN TỬ NÀY ĐƯỢC GỌI LÀ: NULL COALESING - TOÁN TỬ KẾT NỐI

            //Dùng 1 dấu '?': dùng để gọi hàm, kiểm tra xem biến obj có bị null không - NULL CONDITION
            //Dùng 2 dấu "??": dùng để khai báo và gán giá trị cho 1 biến, kiểm tra xem giá trị gán vào có null không, nếu có thì gán bằng giá trị default bên phải - NULL COALESING
            s4.showProfile();



            Student s5 = new Student("SE5", "NĂM", 2005, 5.5);
            Student s6 = s5 ?? new Student("SE6", "LỤC", 2006, 6.6);
            Console.WriteLine("Checking s6...");
            s6.showProfile();
            //HAI CHÀNG TRỎ 1 NÀNG

        }

        static void PlayWithNullV1()
        {
            Student s1;
            //s1.showProfile();//Bị chửi vì biến vẫn còn đang lưu rác, không thể xử lý/gọi hàm được. Rác thì không có hàm để chạy - CompileError
            //Trong Java và C# nói chugn, khai báo biến mà không gán giá trị, cấm không được dùng lệnh ở dưới đó, Tệ nhất cũng phải gán null - Trỏ vào BYTE 0/ĐÁY RAM
            //GIỐNG NHƯ KIM TỐC ĐỘ XE MÁY - NẾU KHÔNG CHẠY THÌ TRẢ VỀ 1 VỊ TRÍ CỐ ĐỊNH(0 KM/H)
            Student s2 = null;
            //s2.showProfile();//báo lỗi!!!NullReferenceException - RuntimeError
            //Để tránh Runtime, ta dùng if, hoặc gán tử tế biến object rồi mới .hàm() để dùng
            //Tại sao lại có NULL để phải check??: DÍNH ĐẾN KQ CỦA SEARCH -> NẾU SEARCH KHÔNG THẤY THÌ PHẢI TRẢ VỀ NULL
            if(s2 is null)
                Console.WriteLine($"Student is not existed. Please assigning or creating an object first before printing it");
            else
                s2.showProfile();
            //CÁCH VIẾT TRÊN HƠI DÀI NHƯNG ỔN, RÕ NGHĨA
            Student s3 = null;
            Console.WriteLine("Checking s3...");
            s3?.showProfile();//GOD FKIN DAWGGG!!!xài '?' cho biến ref vẫn dc
            //TOÁN TỬ NÀY GỌI LÀ "NULL CONDITION OPERATOR"
            //Là phép toán, phép so sánh kiểm tra 1 object "có null hay không" trước khi gọi hàm của nó
            //viết gộp của if-else hay try-catch
            //Tránh bị RUNTIME ERROR
            Student s4 = new Student("SE4", "Tứ", 2004, 4.4);
            Console.WriteLine("Checking s4...");
            s4?.showProfile();
        }

        static void PlayWithNullable()
        {
            Student st3 = new Student("SE1", "An", 2004, 9.2);
            StudentNull st4 = new StudentNull("SE2", "Bình", 2004, null);
            //null tại thời điểm này chỉ áp dụng cho biến object
            //trỏ vào vùng an toàn(byte 0)
            //mang ý nghĩa chưa có sinh viên nào đó cần quan tâm/tìm thấy khi search
            //không áp dụng cho biến primitive(Java)
            //C# offer 1 cơ chế: biến primitive chơi null luôn để tương thích null trong database, vd như cột điểm gpa trong db là null
            //trong code double gpa = null;
            double? gpa = 9.0;
            gpa = null;
            //vậy ta có int?, long?, double?, float?, char?, bool?
            //Vẫn mang giá trị như truyền thống, và còn có thể dc gán thêm null
            //STYLE NÀY ĐƯỢC GỌI LÀ Nullable - em có thể mang null
            
            //kiểm tra thử st4
            st3.showProfile();
            st4.showProfile();
        }

        static void CreateStudentObjects()
        {
            //Tạo mới hồ sơ sinh viên - Tạo mới obj từ templates/class Student
            //Có khuôn - Class ta clone clone
            Student st3 = new Student("SE1", "An", 2004, 9.2);
            st3.showProfile();

            Student st1;            //Xin vùng RAM mà thôi
            //st1.showProfile();      //Vùng RAM chứa rác - GARBAGE VALUE
                                    //RÁC ON OFF CỦA APP TRƯỚC ĐỂ LẠI
                                    //Khai báo biến trong Java và C# mà không có Values thì:
                                    //Cấm không được xài biến ở các câu lệnh phía dưới
                                    //dù biến là primitive hay refence datatype
                                    //NullReferencesException
            int currentYear;
            //Console.WriteLine(currentYear);//Bị chửi vì biến trong RAM đang chứa rác - in rác thì có nghĩa gì? Nhưng trong C in được cả rác

            currentYear = 2024;
            Console.WriteLine($"Current year: {currentYear}");
            //Khai báo biến xong phải gán value cho biến

            Student st2 = null;//Xin RAM và dọn dẹp RAM sạch sẽ, trỏ vào vùng null - Byte đầu tiên của RAM(đáy RAM, tầng lầu thấp nhất của căn hộ)
                               //st2.showProfile();//Bị chửi lúc RUN APP - RUNTIME EXCEPTION
                               //vì trỏ vào vùng new Student() không có data để show()
                               //st2 = new Student(...);//ỔN NHEN, VÌ GIỐNG st3
            st2 = st3;  //Hai chàng trỏ 1 nàng - 2 con trỏ chỉ cùng 1 vùng RAM
                        
            st3._name = "Bình";//Dùng st3 sửa giá trị obj thì st2 cũng bị ảnh hưởng

            st2.showProfile();
            //=>NULL có nghĩa là không xác định OBJECT

            Student st4 = null;
            //st4.showProfile();//Báo lỗi lúc RUNTIME
            st4 = st2;
            if ( st4 != null )//!= null và == null để check 1 biến có đang trỏ null hay không
            {
                st4.showProfile();
            }
            else
            {
                Console.WriteLine("Please create a Student object before printing the profile");
            }

            Console.WriteLine("TEST is null và is not null");
            if ( st4 is not null)
            {
                st4.showProfile();
            }
            if (st4 is null)
            {
                Console.WriteLine("Please create a Student object before printing the profile");
            }

            //st1, st2, st3: pointer - stack memory
            //new Student(...): object(_id="SE1", _name="An", _yob=2004, _gpa=9.2) - HEAP memory
            //                  _id:        variable - heap
            //                  _name:      variable - heap
            //                  _yob:       variable - heap
            //                  _gpa:       variable - heap
            //                  showInfo(): function - heap
            //                  ....
            //st là con trỏ chứa/chỉ tới địa chỉ của object được tạo
            //st. là con trỏ tìm tới địa chỉ đã trỏ, tìm những method, field của obj
        }
    }
}



//BIẾN OBJECT KHI KHAI BÁO Student st; thì có quyền gán bằng những giá trị sau:
//= new 1 VÙNG OBJECT(CALL CONSTRUCTOR)
//= 1 BIẾN OBJECT KHÁC ĐÃ new TRƯỚC ĐÓ (HAI CHÀNG TRỎ 1 NÀNG)
//= NULL trỏ đáy RAM(Muốn Khai báo trước mà không bị SDK báo lỗi)
//dùng: SEARCH 1 OBJECT VÀ KHÔNG TÌM THẤY THÌ TRẢ VỀ NULL
//      TÌM THẤY THÌ TRỎ VÀO VÙNG new Student() nào đó

//MỘT NAMESPACE CÓ THỂ CHỨA NHIỀU CLASS
//CÁC CLASS NÀY CÓ THỂ NẰM RIÊNG BIỆT TRÊN MỖI TẬP TIN HOẶC NÓI CÁCH KHÁC, MỖI TẬP TIN ỨNG VỚI 1 CLASS CODE
//NHƯNG TRONG 1 TẬP TIN VẪN CÓ THỂ CÓ NHIỀU CLASS; NHƯNG XÀI CHUNG 1 TẬP TIN VÀ 1 CÁI TÊN GÌ ĐÓ .CS
//LÀM LẺ: MỖI TẬP TIN 1 CLASS -> THƯ MỤC NAMESPACE HOÀNH TRÁNG, NHƯNG CLASS NÀO RA CLASS ĐẤY VÌ CHÚNG CÓ TÊN RIÊNG
//LÀM GỘP: MỘT TẬP TIN VẬT LÝ CÓ THỂ GỒM NHIỀU CODE CLASS BÊN TRONG -> THƯ MỤC NAMESPACE GỌN GÀNG, NHƯNG KHÔNG BIẾT CHÍNH XÁC CÓ BAO NHIÊU CLASS!!! VÌ CÁC CLASS XÀI CHUNG 1 TẬP TIN
//THƯỜNG NẾU KHÔNG CÓ GÌ ĐẶC BIỆT THÌ MỖI CLASS MỘT TẬP TIN VÀ SHARE CHUNG THƯ MỤC CHỨA CODE(SHARE CHUNG NAMESPACE)
