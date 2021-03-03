using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            string[] clock = time.Split();
            int h = int.Parse(clock[0]);
            int m = int.Parse(clock[1]);
            if (h == 0 && m < 45)
                Console.WriteLine($"{h + 23} {m + 15}");
            else if (m >= 45)
                Console.WriteLine($"{h} {m - 45}");
            else
                Console.WriteLine($"{h-1} {m + 15}");
        }
    }
}
