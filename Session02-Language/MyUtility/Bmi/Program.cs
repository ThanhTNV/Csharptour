namespace Bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = 70;//kg
            double height = 1.7;//meter
            double bmi = weight / (height * height);

            Console.WriteLine($"Your BMI: {bmi}");
        }

        static double calculateBmi(double weight, double height )
        {
            return weight / (height * height);
        }
    }
}
