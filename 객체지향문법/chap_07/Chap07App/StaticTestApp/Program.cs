using System;

namespace StaticTestApp
{
    class TestClass
    {
        public static int number = 10;
        public float fnum;
        public static float ProcSomething()
        {
            Console.WriteLine($"뭔가있음{number}");
            return 1.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass();
            //TestClass.number = 10;
            //aCls.number = 10;
            aCls.fnum = 3.24f;

            TestClass bCls = new TestClass();
            //bCls.number = 10;
            bCls.fnum = 4.87f;

            TestClass.ProcSomething();
        }
    }
}
