using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\GitRepository\StudyCSharp21\SampleDir\SubFolder";

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(new FileStream(filePath, FileMode.Create));
                sw.WriteLine($"int.MaxValue = {int.MaxValue}"); ;
                sw.WriteLine("Hello World!");
                sw.WriteLine($"uint.MaxValue = {uint.MaxValue}");
                sw.WriteLine("안녕하세요");
                sw.WriteLine($"double.MaxValue = {double.MaxValue}");
                Console.WriteLine("파일생성");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일쓰기 예외발생: {ex.Message}");
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
