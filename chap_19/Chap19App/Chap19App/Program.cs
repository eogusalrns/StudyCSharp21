using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(1000);
            }
        }

        static void SomeThingHaappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappened : {i}");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread thread = new Thread(new ThreadStart(DoSomething));
            Thread thread1 = new Thread(SomeThingHaappened);
            thread.Start();
            thread1.Start();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Main Thread : {i}");
                Thread.Sleep(200);

                if (i == 10)
                    thread.Abort();
            }

            thread.Join();
            thread1.Join();

            Console.WriteLine("프로세스 종료");
        }
    }
}
