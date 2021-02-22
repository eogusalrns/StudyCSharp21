using System;

namespace VarTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 100.5f;
            Console.WriteLine($"i값은 {i} 타입은{i.GetType()}");
        }
    }
}
