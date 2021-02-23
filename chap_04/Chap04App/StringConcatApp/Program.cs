using System;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(123 + 456);
            Console.WriteLine("123" + "456");
            Console.WriteLine(123 + "456");
            Console.WriteLine($"{123}456");

            int a = 30, b = 20;
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a != b);

            Console.WriteLine(a > b && a != b);
            Console.WriteLine(a > b || a != b);

            //조건연산자 (삼항)
            int c = 100;
            string result = c == 100 ? "백점" : "안백점";
            Console.WriteLine(result);

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d}");
            Console.WriteLine($"{d ?? 0}");
        }
    }
}
