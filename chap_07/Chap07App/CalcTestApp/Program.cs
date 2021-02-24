using System;

namespace CalcTestApp
{
    class Mathz
    {
        public int Plus(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public void PrintEven(int var)
        {
            if (var % 2 == 0)
                Console.WriteLine($"2의 배수인 값 : {var}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathz mathz = new Mathz();

            int x = 5;
            mathz.PrintEven(x);
            /*if (x % 2 == 0)
                Console.WriteLine($"x의 값 : {x}");*/
            int xx = 10;
            mathz.PrintEven(xx);
            /*if (xx % 2 == 0)
                Console.WriteLine($"x의 값 : {x}");*/
        }
    }
}
