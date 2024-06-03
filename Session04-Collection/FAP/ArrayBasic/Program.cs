namespace ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntegerListV4();
        }


        //CHALLENGE #1: HÃY LƯU TRỮ DÃY SỐ 5, 10, 15, 20, ... 50 VÀ IN RA MÀN HÌNH
        static void PlayWithIntegerListV4()
        {
            int[] arr = new int[10]{ 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]}");

            Console.WriteLine("Print list using for loop:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("Print list using for each:");
            foreach (int i in arr)
            {//toán tử với mọi i thuộc tập số N arr
             //i là 1 con số nguyên có quyền mang giá trị
             //là i = arr[0], i = arr[1], i = arr[2],...
                Console.Write($"{i} ");
            }
            Console.WriteLine();//sống có trách nhiệm
            //vì các biến lẻ dùng [index] để phân biệt(index tăng dần) => vòng lặp xuất hiện
            //==> Mảng chơi với vòng lặp

            //length là biến cuối cùng áp dụng cho mảng(property của vùng new [])
        }
        static void PlayWithIntegerListV3()
        {
            int[] arr = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //new int[]: khai báo nhiều biến int
            //       [0], [1], [2], ...
            //       các biến int như bình thường, kèm theo value
            //       x = 5, x được gọi tên là arr[0]
            //arr LÀ BIẾN MÁ MÌ, QUẢN LÝ DƯỚI TRƯỚNG LÀ 10 EM BIẾN int lẻ, đánh ký hiệu từ [0]
            //arr thực chất là 1 con trỏ, trỏ vào 1 vùng new bự gồm nhiều biến cùng (datatype) nằm liền kề nhau, có địa chỉ là địa chỉ của arr[0], khi muốn truy xuất vào những vùng ram kế bên, thì chỉ cần tính địa chỉ cần truy xuất bằng index * sizeof(datatype)
            //=> arr là biến Object, vì trỏ vùng new bự, phức tạp
            //                                           vì vùng new bự có 10 biến int
            //mảng cũng là biến tham chiếu luôn(Reference)
        }
        static void PlayWithIntegerListV2()
        {
            //delegate lambda LinQ / StreamAPI


            //CÁCH HIỆN ĐẠI, HIỆU QUẢ - KHAI BÁO SỈ - CÚ PHÁP CÁCH VIẾT SẼ RỐI HƠN 1 CHÚT
            int a = 5, b = 10, c = 15, d = 20, e = 25, f = 30, g = 35, h = 40, i = 45, j = 50;
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr2 = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];
            int[] arr3 = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr4 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr5 = new int[10];
            //có 10 biến int riêng lẻ nhưng được khai báo nhanh bằng 1 lệnh(new int[10])
            //arr5[0], arr5[1], arr5[2],...arr5[9]

            arr5[0] = 5; arr5[1] = 10; arr5[2] = 15; arr5[3] = 20; arr5[4] = 25; arr5[5] = 30; arr5[6] = 35; arr5[7] = 40; arr5[8] = 45; arr5[9] = 50;

            //KHAI BÁO MẢNG: MẢNG CHỈ LÀ KĨ THUẬT KHAI BÁO NHIỀU BIẾN (KHAI BÁO SỈ)
            //CÙNG 1 LÚC, CÙNG 1 KIỂU, CÙNG 1 TÊN, Ở SÁT NHAU TRONG RAM

            //KHAI BÁO MẢNG LÀ KHAI BÁO NHIỀU BIẾN CHỨA NHIỀU GIÁ TRỊ TRONG RAM
            //MỘT CÁCH NHANH GỌN, HIỆU QUẢ

            //DO MẢNG LÀ ĐẠI DIỆN CHO NHIỀU BIẾN TRÙNG TÊN TRÙNG KIỂU, DO ĐÓ ĐỂ PHÂN BIỆT TỪNG BIẾN RIÊNG LẺ, TA DÙNG [INDEX](ĐẾM TỪ 0)
            //ĐỌC LÀ: BIẾN THỨ [0], BIẾN THỨ [1], BIẾN THỨ [2],...

            //CÓ 3 THỨ CẦN LƯU Ý KHI CHƠI MẢNG:
            //  TÊN MẢNG
            //  new int[]: KHAI BÁO VÙNG RAM BẰNG NGOẶC VUÔNG
            //  ...

            //int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //int[] arr2 = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];
            //GỌI new NGẦM: new int[10]
            //new (): khai báo bằng constructor | new []: khai báo mảng
        }
        static void PlayWithIntegerListV1()
        {
            //CÁCH TRUYỀN THỐNG KIỂU TRÂU BÒ - KHAI BÁO LẺ, BIẾN LẺ, BIẾN RỜI RẠC, TỪNG BIẾN
            //BIẾN: TÊN GỌI CHO VALUE
            //int a, b, c, d, e, f, g, h, i, j;
            //a = 5; b = 10; c = 15; d = 20; e = 25; f = 30; g = 35; h = 40; i = 45; j = 50;
            int a = 5, b = 10, c = 15, d = 20, e = 25, f = 30, g = 35, h = 40, i = 45, j = 50;
            Console.WriteLine("The list of 5 10 15...");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", a, b, c, d, e, f, g, h, i, j);
            //int[] arrayInt;
        }
    }
}

//CÓ 7 CÁCH KHAI BÁO OBJECT/REFERENCE VARIABLE
// <Class> obj = new <Class>();//NORMAL
// <Class> obj = new(); //new gọn
// var obj = new <Class>();//biến dùng var
// <Class> obj = new <Class>(field1: value, field2: value,...);//NAMED ARGUMENTS
// <Class> obj = new <Class>(){ prop1 = value, prop2 = value, ...};//OBJECT INITIALIZER
// new <Class>();//Anonymous
// *datatype*[] obj = new *datatype*[];//ARRAY INIT