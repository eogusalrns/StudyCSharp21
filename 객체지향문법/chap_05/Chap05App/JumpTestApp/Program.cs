using System;

namespace JumpTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3) continue;
                Console.WriteLine(i);
            }
        }
    }
}
