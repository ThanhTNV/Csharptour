using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace ~ package bên Java. Là 1 thư mục trên HDD/SSD, dùng để lưu trữ các class/src code!!
//Nếu thư mục cha có thư mục con có thư mục cháu, thì chạm đến class thư mục Cháu sẽ là:
// Cha.Con.Cháu.[Class muốn dùng]
//y chang Java
//Muốn dùng class thì phải chỉ ra đường đi

//Bên Java đường đi sẽ là
//Import java.util.Scanner;

//Bên C# sẽ là:
//Using Cha.Con.Cháu;
//Mục đích của việc tạo ra namespace/package(hộp chứa class) để giúp phân loại, quản lý class theo các mục đích khác nhau
//vd: Nhóm class Controller, nhóm class DAO, nhóm class DTO,...
//Nhờ chia class vào trong các thư mục, cho nên 2 thư mục khác nhau có quyền chứa 2 class trùng tên
//NhàMình.ThằngTèo 
//NhàHàngXóm. ThằngTèo
//giải quyết vấn đề đụng độ tên gọi: clash of naming!!!(Naming collision)
namespace MainUI.Lyrics
{
    internal class LyricLibrary
    {
        public static void PrintChungTaCuaTuongLai()
        {
            Console.WriteLine(@"Liệu mai sau phai vội mau không bước bên cạnh nhau (bên cạnh nhau)
Thì ta có đau? (Thì ta có đau? Có đau?)
Đôi mi nhòe phai ai sẽ lau?
Ai sẽ đến lau nỗi đau này?
Vô tâm quay lưng ta thờ ơ, lạnh lùng băng giá như vậy sao? (Vậy sao? Vậy sao?)
Vờ không biết nhau (không biết nhau, không biết nhau)
Lặng im băng qua chẳng nói một lời (chẳng nói một lời)
Ooh-whoa-ooh-whoa-oh-oh-oh (yeah, eh)
Rồi niềm đau có chóng quên? (Hah-ah-ooh-ah)
Hay càng quên càng nhớ thêm, vấn vương vết thương lòng xót xa?
Đừng như con nít (con nít), từng mặn nồng say đắm say (oh-oh-ah)
Cớ sao khi chia tay (chia tay), ta xa lạ đến kì lạ? (Ta xa lạ đến kì lạ)
Ai dám nói trước sau này (trước sau này)
Chẳng ai biết trước tương lai sau này (sau này)
Tình yêu đâu biết mai này có vẹn nguyên
Còn nguyên như lời ta đã hứa trước đây? (Ta đã hứa trước đây)
Dẫu cho giông tố xô xa rời (xa rời)
Còn mãi những điều đẹp đẽ say đắm một thời (một thời)
Nụ cười và giọt nước mắt rơi từng trao cùng ta
Nhìn lại về phía mặt trời (phía mặt trời)
Ta về phía mặt trời (phía mặt trời)
Yah, yah
Tương lai ngày mai ai nào hay (whoa)
Yêu thương rồi buông đôi bàn tay (whoa)
Mong manh đường duyên như vận may
Chia ly, hợp tan nhanh còn hơn mây trời bay (yah)
Quên nhau, vờ như chưa từng quen (sao quên?)
Quên luôn mặt, quên luôn cả tên (sao quên?)
Quên đi, làm sao mà đòi quên?
Khi câu thề xưa vẫn vẹn nguyên nên đừng cố quên (ah)
Vấn vương cũng chẳng sao mà (whoa), nhớ nhung cũng chẳng sao mà (whoa)
Đớn đau cũng chẳng sao mà (whoa)
Dù có đắng cay ta cũng chẳng sao đâu
Chân thành khi còn bên nhau và trân trọng hơn mỗi phút giây (hơn mỗi phút giây)
Thành thật bên nhau mỗi phút giây (yeah, yeah)
Rồi niềm đau có chóng quên? (Hah-ah-ooh-ah)
Hay càng quên càng nhớ thêm, vấn vương vết thương lòng xót xa? (Whoa-oh-oh-oh-oh-oh-oh)
Đừng như con nít (con nít), từng mặn nồng say đắm say (oh-oh-ah)
Cớ sao khi chia tay (chia tay), ta xa lạ đến kì lạ? (Ta xa lạ đến kì lạ, hah)
Ai dám nói trước sau này (trước sau này)
Chẳng ai biết trước tương lai sau này (sau này)
Tình yêu đâu biết mai này có vẹn nguyên
Còn nguyên như lời ta đã hứa trước đây? (Ta đã hứa trước đây)
Dẫu cho giông tố xô xa rời (xa rời)
Còn mãi những điều đẹp đẽ say đắm một thời (một thời)
Nụ cười và giọt nước mắt rơi từng trao cùng ta
Nhìn lại về phía mặt trời
Ai dám nói trước sau này
Chẳng ai biết trước tương lai (trước tương lai, trước tương lai)
Tình yêu đâu biết mai này có vẹn nguyên như lời ta đã hứa trước đây?
Dẫu cho giông tố xô xa rời
Dù cho bão giông chia lìa ta (dù cho bão giông chia lìa ta)
Nụ cười và giọt nước mắt rơi
Để trao tặng em một cơn mơ, y-yah, y-yah (y-yah, y-yah, hah)
Ai dám nói trước sau này (sống bên nhau mà)
Chẳng ai biết trước tương lai sau này (sống bên nhau mà)
Tình yêu đâu biết mai này có vẹn nguyên
Còn nguyên như lời ta đã hứa trước đây? (Ta đã hứa trước đây)
Dẫu cho giông tố xô xa rời (giữ yêu thương kia)
Còn mãi những điều đẹp đẽ say đắm một thời (giữ yêu thương kia)
Nụ cười và giọt nước mắt rơi từng trao cùng ta
Nhìn lại về phía mặt trời (mặt trời)
Ta về phía mặt trời (phía mặt trời, phía mặt trời, phía mặt trời)");
        }
    }
}
