using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sadasdasd
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine(int.Parse(s1) * (int.Parse(s2) % 100 % 10));
            Console.WriteLine(int.Parse(s1) * ((int.Parse(s2) % 100 - (int.Parse(s2) % 100 % 10))/10));
            Console.WriteLine(int.Parse(s1) * ((int.Parse(s2) - (int.Parse(s2) % 100 ))/100));
            Console.WriteLine(int.Parse(s1) * (int.Parse(s2)));
        }
    }
}
