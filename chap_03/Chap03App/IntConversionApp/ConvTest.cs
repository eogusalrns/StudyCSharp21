using System;

namespace IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short 형 갑변환 int값은 {inCastVal}");

            inCastVal += 5;
            short shCastVal = (short)inCastVal;
            Console.WriteLine($"int 형 갑변환 short값은 {shCastVal}"); //overflow

            float flVal = 3.141592F;//f of F
            inCastVal = (int)flVal;
            Console.WriteLine($"float 형 갑변환 int값은 {inCastVal}");
            double dlVal = inCastVal;//3
            Console.WriteLine($"int 형 갑변환 double값은{dlVal}");

            object obj = 20; //boxing
            int inUnboxingVal = (int)obj;//Unboxing
            Console.WriteLine($"obj형 값 변환 int값은 {obj}");

            string strVal = "200";
            int result = int.Parse(strVal) * 3;//문자열을 숫자로 형변환
            Console.WriteLine($"200*3 = {result}");
        }
    }
}
