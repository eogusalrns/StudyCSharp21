using System;

namespace UsingEventApp
{

    class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += MyHandler;//이벤트를 내가만든 로직이 있는 메서드랑 연결

            for (int i = 0; i <= 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
