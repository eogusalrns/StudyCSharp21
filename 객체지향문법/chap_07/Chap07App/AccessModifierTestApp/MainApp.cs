using System;

namespace AccessModifierTestApp
{
    class Boiler
    {
        private int temp = 5;
        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 벗어남. 다시 셋팅할것.");
                return;
            }
            else
            {
                this.temp = 59;
            }
        }
        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켜요");
        }

        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 꺼요");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            var currTemp =kitturami.GetTemp();
            Console.WriteLine($"현재 온도는 {currTemp}℃");
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);
            if (kitturami.GetTemp() >= 59)
                kitturami.TurnOffBoiler();
        }
    }
}
