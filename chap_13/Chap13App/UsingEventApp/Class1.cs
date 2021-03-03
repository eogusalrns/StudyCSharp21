using System;
using System.Collections.Generic;
using System.Text;

namespace UsingEventApp
{
    delegate void EventHandler(string message);

    class CustomNotifier
    {
        public event EventHandler SomethingHappened;//대리자의 인스턴스 이벤트

        public void DoSomething(int number)
        {
            int temp = number % 10;//46 % 10 = 6 % 3 = 0

            if (temp != 0 && temp % 3 == 0)
                SomethingHappened($"{number} : 박수");//이벤트를 사용(로직 없음)
        }
    }
}