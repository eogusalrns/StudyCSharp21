using System;

namespace AccessModifierTestApp
{
    class Boiler
    {
        int temp = 5;
        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
                Console.WriteLine("물의 온도가 벗어남. 다시 셋팅할것.");
            this.temp = temp;
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
}
