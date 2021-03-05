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
            int[] arr = new int[cnt];
            int max = 0;
            int hap = 0;
            for (int i = 0; i < cnt; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (max < arr[i])
                    max = arr[i];
            }
            for (int i = 0; i < cnt; i++)
            {
                arr[i] = arr[i] / max * 100;
                hap += arr[i];
            }
            Console.WriteLine(hap);
        }
    }
}
