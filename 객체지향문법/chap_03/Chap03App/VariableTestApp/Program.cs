using System;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int v1 = 30, v2 = 40;
            //int result = v1 + v2;
            //console.writeline("결과는 " + result);
            sbyte sbminval = sbyte.MinValue;
            sbyte sbmaxval = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소,최대값은 {sbminval}, {sbmaxval}");

            byte bminval = byte.MinValue;
            byte bmaxval = byte.MaxValue;
            Console.WriteLine($"byte 최소,최대값은 {bminval}.{bmaxval}");

            short sminval = short.MinValue;
            short smaxval = short.MaxValue;
            Console.WriteLine($"short 최소,최대값은 {sminval},{smaxval}");

            int iminval = int.MinValue;
            int imaxval = int.MaxValue;
            Console.WriteLine($"int 최소,최대값은 {iminval},{imaxval}");

            float fminval = float.MinValue;
            float fmaxval = float.MaxValue;
            Console.WriteLine($"float 최소,최대값은 {fminval},{fmaxval}");

            double dminval = double.MinValue;
            double dmaxval = double.MaxValue;
            Console.WriteLine($"double 최소,최대값은 {dminval},{dmaxval}");

            decimal dcminval = decimal.MinValue;
            decimal dcmaxval = decimal.MaxValue;
            Console.WriteLine($"decimal 최소,최대값은 {dcminval},{dcmaxval}");
        }
    }
}
