using StudentManagementHomework.Services;

namespace StudentManagementHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet studentSE = new Cabinet();
            Cabinet studentSS = new Cabinet();
            bool runApp = true;
            while (runApp)
            {
                ShowMenu();
                int choice = GetChoice();
                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("___ADD NEW SE STUDENT___");
                            studentSE.AddStudent(StudentManager.createStudent());
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("___ADD NEW SS STUDENT___");
                            studentSS.AddStudent(StudentManager.createStudent());
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("___LIST OF SE STUDENT___");
                            studentSE.PrintList();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("___LIST OF SE STUDENT___");
                            studentSS.PrintList();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("We are developing this feature");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Goodbye <3");
                            runApp = false;
                            break;
                        }
                }
            }
        }


        static void ShowMenu()
        {
            Console.WriteLine("=======Student Manager=======");
            Console.WriteLine("1. Add a new SE Student");
            Console.WriteLine("2. Add a new SS Student");
            Console.WriteLine("3. Print list of SE Student");
            Console.WriteLine("4. Print list of SS Student");
            Console.WriteLine("5. Will be more features later! <3");
            Console.WriteLine("6. QUIT");
        }

        static int GetChoice()
        {
            int choice = 0;
            Console.WriteLine("Enter your choice: ");
            do
            {
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 6)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Must be between 1-6");
                }
            } while (choice < 1 || choice > 6);
            return choice;
        }
    }
}
//HOMEWORK: ASSIGNMENT #2: LMS - 10/6 (14H59)
//VIẾT THÊM BÊN MAIN() CÁI MENU IN RA
//1. THÊM MỚI
//2. IN
//3. XÓA
//4. THÊM
//...
//NHẬP TỪ BÀN PHÍM
//NHỚ PHẢI BIẾT CÁCH CONVERT TỪ CHUỖI SANG SỐ, PARSE INT

//VIẾT THÊM TỦ ĐỰNG HỒ SƠ GIẢNG VIÊN: ID, NAME, YOB, SALARY