using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class MyClass
    {
        private int ivalue;//0~120 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

        public int IValue
        {
            get 
            {
                return this.ivalue;
            }
            set
            {
                if (value < 0)
                    this.ivalue = 0;
                else if (value > 120)
                    this.ivalue = 120;
                else
                    this.ivalue = value;
            }
        }
        public MyClass(int ivalue)
        {
            IValue = ivalue;
        }

        /*       public int GetValue()
               {
                   return this.ivalue;
               }*/

    /*        public void SetValue(int value)
    {
        if (value < 0)
            this.value = 0;
        else if (value > 120)
            this.value = 120;
        else
            this.value = value;
    }*/
        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.ivalue}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass(1000);
            cls.PrintValue();

            cls.IValue = 1200;
            //cls.SetValue(100);
            cls.PrintValue();
            Console.WriteLine($"현재 온도는 {cls.IValue}℃");

        }
    }
}
