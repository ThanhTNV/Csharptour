namespace BmiV2
{
    /// <summary>
    /// Class này sẽ chứa các hàm liên quan đến các chỉ số BMI, là các chỉ số liên quan đến chiều cao và cân nặng, giúp đánh giá 1 ai đó có mập ốm hay không
    /// </summary>
    public class BmiCalculator
    {
        //Khai báo biến, hàm => gọi chung là members của 1 class
        //biến: gọi là "field"/"props"/"attribute"/"instance variable"(static variable)/"class-variable"(non-static variable)
        //Math.sqrt() Math.Sqrt()

        //Tên hàm trong Java: Verb+Obj, chữ hoa từng đầu từ, từ đầu tiên viết chữ thường(camelCaseNotation)
        //vd: sqrt(), toString(), getGpa()
        //Tên hàm trong C#: Verb+Obj, chữ hoa từng đầu từ, kể cả từ đầu tiên(PascalCaseNotation)
        //Vd: Sqrt(), ToString(), GetGpa()

        /// <summary>
        /// Hàm này tính trị số BMI của một cá nhân bất kì và trả về con số đó. Phép tính BMI dựa trên chiều cao và cân nặng.
        /// </summary>
        /// <param name="weight">Kilogram</param>
        /// <param name="height">Meter</param>
        /// <returns>Hàm trả ra double BMI</returns>

        public static double GetBmi(double weight, double height) => (weight / (height * height));
        //nếu hàm CHỈ CÓ MỘT CÂU LỆNH DUY NHẤT, cho phép ĂN BỚT(rút gọn code)
        //bỏ luôn "return", "{" và "}"
        //kỹ thuật viết thân hàm {...} theo style rút gọn được gọi là EXPRESSION BODY - BODY như một biểu thức

        //CẤM KHÔNG ĐƯỢC NHẦM LẪN VỚI BIỂU THỨC LAMBDA - CŨNG XÀI CHUNG DẤU "=>"(HỌC SAU)


        //static double GetBmi(double weight, double height) 
        //    =>
        //        weight / (height * height);

        //static double GetBmi(double weight, double height) =>
        //weight / (height * height);

        //static double GetBmi(double weight, double height)
        //{
        //    //quy tắc đặt tên biến - local: camelCaseNotation(Noun)
        //    return weight / (height * height);
        //}

        public static void printbmistring() => Console.WriteLine("bmi stand for body mass index - chỉ số khối của cơ thể - con số được tính dựa trên chiều cao và cân nặng");

        //static void PrintBmiString()
        //{
        //    Console.WriteLine("BMI stand for Body Mass Index - chỉ số khối của cơ thể - con số được tính dựa trên chiều cao và cân nặng");
        //}
    }
}
