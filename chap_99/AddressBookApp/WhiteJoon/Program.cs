using System;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split();
                int x = int.Parse(ss[0]);
                int y = int.Parse(ss[1]);
                Console.WriteLine(x + y);
            }
        }
    }
}
