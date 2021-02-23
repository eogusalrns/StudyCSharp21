using System;

namespace InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long idx = 0;
/*
            for (; ; )
            {
                Console.WriteLine($"idx = {idx++}");
            }//무한루프*/

            while(true)
                Console.WriteLine($"idx = {idx++}");
        }
    }
}
