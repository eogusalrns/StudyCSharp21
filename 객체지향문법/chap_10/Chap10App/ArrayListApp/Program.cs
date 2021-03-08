using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList({ 80, 74, 81, 90, 34 });
            /*array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);*/
            var loc = array.IndexOf(81);
            array.Insert(loc, 50);
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
            array.Remove(90);
            Console.WriteLine("----------------------");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
            array.Sort();
            Console.WriteLine("----------------------");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
            array.Reverse();
            Console.WriteLine("----------------------");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
