using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SideTaskApp
{
    class sideTask
    {
        int Count { get; set; }

        public sideTask(int Count)
        {
            this.Count = Count;
        }

        public void CountDown()
        {
            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음");
                    Count--;
                    Thread.Sleep(100);
                }
                Console.WriteLine($"Count : {Count}"); // 0
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
                Thread.ResetAbort();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"스레드 예외 발생 : {ex.Message}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sideTask task = new sideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false;// 이 스레드가 종료되기 전까지는 프로세스가 끝나지가 않음
            //true면, 백그라운드 스레드가 돌고있는 상태여도 메인스레드가 끝나면 백그라운드도 끝남
            sideTask task2 = new sideTask(200);
            Thread th2 = new Thread(task2.CountDown);

            Console.WriteLine("스레드 시작!");
            th.Start();
            th2.Start();
            Thread.Sleep(1000);
            Console.WriteLine("임의 종료");
            th.Abort();
            Console.WriteLine("종료 대기");
            th.Join();
            th2.Join();
            Console.WriteLine("스레드/프로세스 종료!");
        }
    }
}
