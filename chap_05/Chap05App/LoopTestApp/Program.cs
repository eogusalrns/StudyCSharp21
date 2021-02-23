using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine($"숫자는 {a--}");
            }
            Console.WriteLine("출력종료");

            do
            {
                Console.WriteLine($"숫자 {++a}");
            } while (a < 10);

            Console.WriteLine("for 문");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}단 시작!");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
