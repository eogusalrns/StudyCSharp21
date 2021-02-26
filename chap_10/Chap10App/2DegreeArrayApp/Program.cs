using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DegreeArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3, }, { 4, 5, 6 } };
            int cnt = 0;
            Console.WriteLine(arr);
            //arr[0, 0] = 1;
            for (int i = 0; i < arr.GetLength(0); i++,cnt++)
            {
                for (int j = 0; j < arr.GetLength(1); j++,cnt++)
                {
                    //arr[i, j] = cnt;
                    Console.WriteLine($"[{i} , {j}] : {arr[i, j]}");
                }
                Console.WriteLine("");
            }
        }
    }
}
