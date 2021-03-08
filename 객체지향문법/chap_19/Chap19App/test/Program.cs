using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();
            int max = 0;
            int min = 100;

            for (int i = 0; i < cnt; i++)
            {
                Console.Read();
                str.Append(cnt);
                if (max < str[i])
                    max = str[i];
                if (min > str[i])
                    min = str[i];
            }
            Console.Write(min + " " + max);
        }
    }
}
