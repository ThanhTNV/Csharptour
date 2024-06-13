using ListBasic.Entities;
using System.Collections;

namespace ListBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithArrayList();
        }

        static void PlayWithList()
        {
            List<Student> arr = new List<Student>();
            //Java: List<Student> arr = new List<>(); ĂN ĐÒN - ANONYMOUS CLASS
            //Java: List<Student> arr = new ArrayList<>();
            //Java: ArrayList<Student> arr = new ArrayList<>();
            arr.Add(new Student() { Id = "SE1", Name = "An"});
            arr.Add(new Student() { Id = "SE2", Name = "Binh" });
            arr.Add(new Student() { Id = "SE3", Name = "Cuong" });
            //3 biến dc sinh ra, trỏ 3 vùng new
            Console.WriteLine("The list of Students;");
            for (int i = 0; i < arr.Count; i++)
            {
                //arr[i].ShowProfile();
                arr.ElementAt(i).ShowProfile();//get(i) bên Java
            }

        }

        //JAVA: List (abstract), ArrayList(Concrete Class)
        //      List<Student> arr = new ArrayList<>();
        //      ArrayList<Student> arr = new ArrayList<>();
        //Cấm không được new List<>(), vì nếu ngoan cố new List() thì sẽ bị đập vào mặt khoảng 20 hàm cần viết code @Override
        //KỸ THUẬT ANONYMOUS CLASS - CLASS ẨN DANH
        

        //C# khác: 
        //ArrayList new ArrayList() ko có generic!!!!
        //KHUYÊN KHÔNG NÊN DÙNG ARRAYLIST CỦA C#
        static void PlayWithArrayList()
        {
            ArrayList arr = new ArrayList();
            //new ArrayList() ~ new int[]
            //chừng nào gán value thì mới thêm biến tương ứng
            arr.Add(5);     //arr[0] = 5
            arr.Add(10);    //arr[1] = 10
            arr.Add(15);    //arr[2] = 15
            arr.Add(20);    //arr[3] = 20
            arr.Add("ABCXYZ");//KO TYPE-SAFE
                              //DATA LỘN XỘN DATATYPE
            arr.Add(3.14);
            arr.Add(false);
            arr.Add(new Student() { Id = "SE1", Name = "An" });

            //for tới bến luôn, khỏi cần biến count
            //Array phiên bản ngon lành hơn vì không cấp dư vùng RAM trong vùng new(Co dãn)
            Console.WriteLine("The list of numbers");
            for (int i = 0; i < arr.Count; i++)//arr.size() bên Java
            {
                Console.WriteLine(arr[i]);   //arr.get() bên Java
            }
            Console.WriteLine();
            Console.WriteLine(arr.Count);
            //KHÔNG KHUYÊN DÙNG VÌ LỘN XỘN DATA TYPE
            //[i]. KHÔNG BIẾT NÊN XỔ RA GÌ, VÌ LỘN XỘN CẢ OBJECT, VÀ PRIMITIVE
            //CHƯA KỂ LỘN XỘN OBJECT, STUDENT, LECTURER, PET,...
            //MỖI OBJECT CÓ . RIÊNG CỦA NÓ
        }
    }
}
