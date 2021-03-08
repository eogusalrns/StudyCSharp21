using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b);
    class Program
    {
        //오름차순 a>b 1 a=b 0 a<b -1
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }
        //내림차순 a<b 1 a=b 0 a>b -1
        static int DescendingCompaer(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }
        static void BubbleSort(int[] Dataset,Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < Dataset.Length; i++)
            {
                for (int j = 0; j < Dataset.Length - (i+1); j++)
                {
                    if (comparer(Dataset[j],Dataset[j+1]) > 0)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*Compare comp = new Compare(AscendCompare);
            Console.WriteLine(comp(5, 3));
            comp = new Compare(DescendingCompaer);
            Console.WriteLine(comp(5, 3));*/
            int[] array = { 3, 8, 4, 2, 1, 10 };
            Console.WriteLine("Sorting");
            BubbleSort(array, new Compare(AscendCompare));
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
