using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06App
{
    class Calcurator
    {
        public static int Plus ( int a, int b )
        {
            int result = a + b;
            return result;
        }

        static void Main(string[] args)
        {
            int x = Calcurator.Plus(3, 4);
            int y = Calcurator.Plus(5, 6);
            int z = Calcurator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}");
        }
    }
}
