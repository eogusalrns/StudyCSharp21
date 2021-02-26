using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Test { }

    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[5];
            //var array = new int[5];
            int[] array = { 0, 10, 100, 1000, 10000 };
            Array.Resize(ref array, 6);
            for (int i = 0; i < array.Length ; i++)
            {
                //array[i] = 10 * i;
                Console.WriteLine($"{i}번째 값: {array[i]}");
            }
            Console.WriteLine("1000인덱스찾기-------------------");
            int idx = Array.IndexOf(array, 1000);
            for (int i = array.Length -1; i >= idx; i--)
            {
                array[i] = array[i - 1];
                Console.WriteLine($"{i}번째 값: {array[i]}");
            }
/*            var idx = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값: {item}");
            }*/

            /*array[0] = 800;
            array[1] = 8000;
            array[2] = 80000;
            array[3] = 8000;
            array[4] = 800;
            Console.WriteLine($"0번째 값: {array[0]}");
            Console.WriteLine($"1번째 값: {array[1]}");
            Console.WriteLine($"2번째 값: {array[2]}");
            Console.WriteLine($"3번째 값: {array[3]}");
            Console.WriteLine($"4번째 값: {array[4]}");*/

/*            Console.WriteLine($"{array.GetType()}");

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값: {array[i]}");
            }
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값: {array[i]}");
            }
            int idx = Array.IndexOf(array, 0);
            Console.WriteLine($"40의 인덱스 : {idx}");

            Array.Clear(array,3,2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값: {array[i]}");
            }*/
        }
    }
}
