using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap14App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*List<int> result = new List<int>(); LINQ안쓰는방식

            foreach (var item in num)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
*/          //LINQ쓰는 방식
            var result = from item in num
                         where item % 2 == 0
                         orderby item descending
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }
        }
    }
}
