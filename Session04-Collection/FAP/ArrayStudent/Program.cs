using ArrayStudent.Entities;
using System.Collections;

namespace ArrayStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentListV2();
        }
        //CHALLENGE #2: HÃY LƯU THÔNG TIN, HỒ SƠ CỦA 30 BẠN SINH VIÊN TRONG PHÒNG NÀY
        //GIẢI PHÁP 1: KHAI BÁO 30 BIẾN STUDENT (CHƠI NGOO)
        //GIẢI PHÁP 2: KHAI BÁO BẰNG MẢNG(NGUYÊN THỦY)
        //GIẢI PHÁP 3: KHAI BÁO BẰNG LIST(MẢNG HIỆN ĐẠI - HẠI ĐIỆN)
        static void PlayWithStudentListV2()
        {
            Student[] arr = new Student[30];
            //      má mì   có nhiều biến Student
            //              s1, s2, s3, s4, s5,... chưa có hồ sơ sv thực sự!!!

            //mảng primitive: arr[0] = 5; là xong
            //nhưng mảng object: arr[0] là 1 sinh viên, trỏ vùng new Student()
            //                => arr[0] = new Student(){Prop1 = Value1, Prop2 = Value2, ...};

            //0986 628 525: Giáo Làng
            arr[0] = new Student() { Id = "SE1", Name = "An" };//OBJECT INITIALIZER
            arr[1] = new Student() { Id = "SE2", Name = "Binh", Yob = 2004 };
            arr[2] = new Student() { Id = "SE3", Name = "Cuong" };
            arr[3] = new Student() { Id = "SE4", Name = "Dung", Yob = 2004, Gpa = 8.6 };

            //IN MẢNG SV THEO 2 CÁCH(FOR LOOP, FOREACH LOOP)
            Console.WriteLine("Print student profile using for loop:");
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i].ShowProfile();//Báo lỗi NullReferenceException
                //if (arr[i] is not null) arr[i].ShowProfile();
                arr[i]?.ShowProfile();//thay thế cho if is not null
            }
            Console.WriteLine("Print student profile using for each:");
            foreach (Student student in arr)
            {
                //student.ShowProfile();//Báo lỗi NullReferenceException
                student?.ShowProfile();
            }
            //CÁCH DÙNG NÀY KHÔNG HAY, VÌ PHẢI DUYỆT TỚI TỪNG ELEMENT TRONG MẢNG(KỂ CẢ NHỮNG PHẦN TỬ MANG GIÁ TRỊ NULL)

            //DEFAULT CỦA BIẾN OBJECT(Object/Reference variable) LÀ NULL => nếu không new để xin vùng RAM thì dính NullReferenceException/NullPointerException
            //còn khi xin vùng RAM(gọi hàm new Student()), biến object sẽ chỉ tới 1 vùng RAM(tức là đã có giá trị), trong vùng RAM xuất hiện những biến default(primitive variable) của đối tượng được new

            //để thao tác với 1 mảng nguyên thủy dễ dàng, tránh va vào vùng nhớ chưa khởi tạo new
            //ta sử dụng thêm 1 biến count để xác định kích thước tạm thời của mảng(Hay còn gọi là kích thước giả - Kích thước của mảng đang chứa giá trị) với kỹ thuật for loop
            
        }
        static void PlayWithStudentList()
        {
            Student[] studentList = new Student[30];
            //Mảng nguyên thủy trong C# có thể dùng để chứa Object (Thật vãi cả..)
            foreach (var student in studentList)
            {
                //từng thằng student trong đây là 1 vùng HEAP
                //student chính là studentList[index]
                //nhưng không thể khai báo/gọi hàm constructor để gán cho student, vì student đang trong vòng for each, là 1 biến foreach iteration variable, không thể gán bằng hàm constructor
                //student = new Student() { Id = "SE1", Name = "An" };
            }
            //studentList[0], studentList[1], ... chính là từng biến sinh viên riêng lẻ(Reference Variable), được gom lại và quản lý bởi 1 biến mang tên studentList(cũng là Reference Variable)
            studentList[0] = new Student() { Id = "SE1", Name = "An" };
            studentList[1] = new Student() { Id = "SE2", Name = "Bình" };
            Student s2 = new() { Id = "SE3", Gpa = 8.7, Name = "Cường", Yob = 2004 };
            studentList[2] = s2;
            studentList[3] = studentList[0];

            ArrayList studentList2 = new ArrayList();
            studentList2.Add(new Student());
        }
        static void CreateStudent()
        {
            Student s1 = new Student();//default constructor
                                       //default _backing field
            s1.Id = "SE1";
            s1.Name = "An";
            s1.Gpa = 8.6;
            s1.Yob = 2004;
            s1.ShowProfile();

            Student s2 = new() { Id = "SE2", Gpa = 8.7, Name = "Bình", Yob = 2004 };
            //OBJECT INITIALIZER
            s2.ShowProfile();
        }
        static void Homework()
        {
            Student[] studentList = new Student[5];
            InitDataHomeWork(studentList);
            foreach (Student student in studentList)
            {
                student.ShowProfile();
            }
            for (int i = 0; i < studentList.Length - 1; i++)
            {
                for (int j = i + 1; j < studentList.Length; j++)
                {
                    if (studentList[i].Gpa > studentList[j].Gpa)
                    {
                        Student tmp = studentList[i];
                        studentList[i] = studentList[j];
                        studentList[j] = tmp;
                    }
                }
            }

            Console.WriteLine("After sort:");
            foreach (Student student in studentList)
            {
                student.ShowProfile();
            }
        }
        static void InitDataHomeWork(Student[] studentList)
        {
            string[] idList = new string[5];
            for (int i = 0; i < idList.Length; i++)
            {
                string rootId = "SE";
                int firstNum = new Random().Next(0, 9);
                int secondNum = new Random().Next(0, 9);
                string numId = firstNum.ToString() + secondNum.ToString();
                idList[i] = string.Concat(rootId, numId);
            }

            string[] nameList = new string[5] { "Emily Brown", "David Miller", "Jessica Smith", "Michael Jones", "Sarah Johnson" };

            double[] randGpa = new double[5];
            for (int i = 0; i < randGpa.Length; i++)
            {
                randGpa[i] = new Random().Next(0, 10);
            }

            for (int i = 0; i < 5; i++)
            {
                studentList[i] = new Student() { Id = idList[i], Name = nameList[i], Gpa = randGpa[i], Yob = 2004 };
            }

        }
    }
}


//BTVN: HÃY LƯU THÊM 5-10 SINH VIÊN VỚI ĐIỂM LỘN XỘN THỨ TỰ
//IN RA DANH SÁCH SINH VIÊN
//SẮP XẾP DS THEO GPA TĂNG DẦN VÀ IN RA MÀN HÌNH

//có thể hiểu:
//1. Biến arr:
//  - Là 1 Object Variable, mang giá trị default(NULL)
//  - Gán giá trị cho biến arr bằng cách khởi tạo 1 vùng RAM cho mảng(new Student[])
//  - Vùng RAM chứa các Object Variable arr[0], arr[1], ..., arr[29] và 1 Prop mang tên Length, mang giá trị là độ dài(độ lớn) của arr
//2. Biến arr[0], arr[1], ...:
//  - Là 1 Object Variable, mang giá trị default(NULL)
//  - Giá trị tương đương với Student s1; Student s2;...
//  - Nếu new Student() thì sẽ khởi tạo 1 vùng RAM và trỏ vào vùng RAM vừa được khởi tạo, chứa đầy đủ các Prop và Method bên trong
//3. Vùng new Student():
//  - Là 1 vùng nhớ được khởi tạo
//  - Bên trong nó gồm các Prop và Method dựa theo Class
//  - Các Prop mang giá trị Default khi vừa khởi tạo(number = 0; String = ""; boolean = false)

//CHỐT HẠ VỀ DẤU CHẤM
//TÊN MẢNG, MÁ MÌ CHẤM THÌ XỔ RA LENGTH(KHÔNG CARE LOẠI MẢNG)

//MẢNG PRIMITIVE, [I] CHẤM VÔ NGHĨA, VÌ BIẾN PRIMITIVE CÓ VALUE LUÔN RỒI, KHÔNG CHỨA GÌ BÊN TRONG NỮA(5, 10, 15, 20,...)
//MẢNG OBJECT THÌ [I] CHẤM XỔ RA QTQĐ TRONG VÙNG NEW