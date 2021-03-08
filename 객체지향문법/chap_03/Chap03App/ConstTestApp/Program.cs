using System;

namespace ConstTestApp
{
    class Program
    {
        enum season
        {
            Spring=1000,
            Summer=2000,
            Fall=3000,
            Winter=4000
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수 테스트");
            const double pi = 3.141592;
            Console.WriteLine($"원주율의 값은 {pi}");

            season mySeason = (season)4000;
            Console.WriteLine($"지금 계절은 {mySeason}");

            int a = 0;
            int? b = null;
            Console.WriteLine($"a는 ? {a} b는 ? {b}");
        }
    }
}
