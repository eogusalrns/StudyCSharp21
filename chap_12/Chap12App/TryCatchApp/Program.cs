using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    i /= 0;
                    Console.WriteLine($"{i} : {arr[i]}");
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                //throw;
            }
            catch (Exception exo)
            {
                Console.WriteLine($"예외의 예외 : {exo.Message}");
            }
            Console.WriteLine("나머지 일처리 계소ㅓㄱ...");

            try
            {
                int x = 108, y = 0;
                int result = x / y;
                Console.WriteLine(result);

            }
            catch (DivideByZeroException exe)
            {
                Console.WriteLine($"예외발생 : {exe.Message}");
                //throw;
            }
            Console.WriteLine("다시 일처리 계소ㅓㄱ...");

            string strVal = "hello World";
            string splitVal = strVal.Substring(6, 5);
            Console.WriteLine($"자른 문자 : {splitVal}");
            //int index = strVal.IndexOf("W");
            //Console.WriteLine($"W의 위치 {index}");
        }
    }
}
