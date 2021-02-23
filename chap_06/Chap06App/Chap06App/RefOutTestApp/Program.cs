using System;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int quo, rem;
            Divide(a, b, out quo, out rem);
            Console.WriteLine($"{a} / {b} 의 몫 {quo} 나머지 {rem}");
            bool isSucceed = int.TryParse("1000", out int result);
            Console.WriteLine($"변환결과{isSucceed} result값{result}");
        }
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
