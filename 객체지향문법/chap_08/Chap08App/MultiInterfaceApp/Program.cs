using System;

namespace MultiInterfaceApp
{
    interface IRunnable //탈 것
    {
        void Run();
    }

    interface IFlyable //나르는 것
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아");
        }

        public void Run()
        {
            Console.WriteLine("달려");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar droneCar = new DroneCar();
            droneCar.Run();
            droneCar.Fly();

            Console.WriteLine("자동차로 변경");
            IRunnable car = droneCar;
            car.Run();

            Console.WriteLine("비행기로 변경");
            IFlyable plane = droneCar;
            plane.Fly();
        }
    }
}
