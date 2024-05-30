using BmiV2;

namespace LibraryUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double bmi = BmiV2.BmiCalculator.GetBmi(74, 1.72);
            //Console.WriteLine(bmi);
            //Console.WriteLine(BmiV2.BmiCalculator.GetBmi(74, 1.72));
            Console.WriteLine(BmiCalculator.GetBmi(74, 1.72));
        }
    }
}
