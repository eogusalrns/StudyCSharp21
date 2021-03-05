using System;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            int c = 0;
            while (true)
            {
                c = a + b;
                a = b;
                b = c;
                if ( a == ss[0] && b)
            }
        }
    }
}