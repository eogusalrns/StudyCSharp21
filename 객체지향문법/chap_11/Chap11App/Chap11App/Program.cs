using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 };
            int[] target = new int[source.Length];

            CopyArray(source, target);
            
            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);

            float[] source3 = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f };
            float[] target3 = new float[source3.Length];

            CopyArray(source3, target3);
        }

        private static void CopyArray(float[] source, float[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
                Console.WriteLine(target[i]);
            }
        }

        private static void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
                Console.WriteLine(target[i]);
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
                Console.WriteLine(target[i]);
            }
            /*foreach (var item in source)
            {
                target[item] = source[item];
            }*/
        }
    }
}
