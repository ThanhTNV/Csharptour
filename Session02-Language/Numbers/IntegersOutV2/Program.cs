namespace IntegersOutV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Challenge1(out int sum, out int sumOdd, out int sumEven, out int countOdd, out int countEven, out int countPrime);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Sum Odd = " + sumOdd);
            Console.WriteLine("Sum Even = " + sumEven);
            Console.WriteLine("Count Even = " + countEven);
            Console.WriteLine("Count Odd = " + countOdd);
            Console.WriteLine("Count Prime = " + countPrime);
            //1..10: 1 2 3 4 5 6 7 8 9 10
            //EXPECTED:
            //Sum all: 55
            //Sum odds: 1 3 5 7 9 = 25
            //Sum evens: 2 4 6 8 10 = 30
            //Count odds: 5
            //Count evens: 5
            //Count prime: 2 3 5 7: 4
            //ACTUAL:
            //Sum all: 55
            //Sum odds: 25
            //Sum evens: 30
            //Count odds: 5
            //Count evens: 5
            //Count prime: 4
        }

        //CHALLENGE #1: Viết 1 hàm trả về
        //Tổng các số từ 1..10
        //Tổng các số lẻ từ 1..10
        //Tổng các số chẵn từ 1..10
        //Số lượng các số lẻ từ 1..10
        //Số lượng các số chẵn từ 1..10
        //Số lượng các số nguyên tố 1..10
        static void Challenge1(out int sum, out int sumOdd, out int sumEven, out int countOdd, out int countEven, out int countPrime)
        {
            sum = 0;
            sumOdd = 0;
            sumEven = 0;
            countOdd = 0;
            countEven = 0;
            countPrime = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                if(i % 2 == 0)
                {
                    sumEven += i;
                    countEven++;
                } 
                else 
                {
                    sumOdd += i;
                    countOdd++;
                }

                if (IsPrime(i)) countPrime++;
            }
        }

        static bool IsPrime(int n)
        {
            for(int i = 2; i <= Math.Sqrt(n); i++)
                if(n % i == 0)
                    return false

            return n >= 2;
        }
    }
}
