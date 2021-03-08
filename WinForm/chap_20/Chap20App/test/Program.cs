using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            int[] arr = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                int count = 0;
                string x = Console.ReadLine();
                string[] xx = x.Split();
                int hap = 0;
                int num = int.Parse(xx[0]);
                for (int j = 1; j < xx.Length; j++)
                {
                    hap += int.Parse(xx[j]);
                }
                int avg = hap / (xx.Length - 1);
                for (int j = 1; j < xx.Length; j++)
                {
                    if (int.Parse(xx[j]) > avg)
                        count++;
                }
                Console.WriteLine("{0:#0.000%}", (float)count / (xx.Length - 1));
                
            }
        }
    }
}
