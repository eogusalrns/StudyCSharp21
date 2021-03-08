using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = '\t';
            char c2 = 'T';
            char c3 = '0';
            char c4 = '\n';
            char c5 = '\\';
            Console.WriteLine($"{c1},{c2},{c3},{c4},{c5}");

            string str1 = "Hello, \tWorld!";
            Console.WriteLine($"{str1}");

            bool isCorrect = false;
            if(isCorrect)
            {
                Console.WriteLine("참입니다.");
            }
            else
            {
                Console.WriteLine("거짓입니다.");
            }
        }
    }
}
