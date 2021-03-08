using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!\n");
            //sb[6] = 'N';//권장 X
            sb.Append("My name is Ruo\n");
            sb.Append("I'm old.\n");
            sb.Append("Book Price is 30000 won.\n");
            sb.Insert(6, "new ");
            sb.Replace("Book", "시계");
            Console.WriteLine(sb);
        }
    }
}
