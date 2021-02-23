using System;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("최대현", "010-8984-7695");

            if (PrintProfile(null, "010-1111-2222") == -1)
                Console.WriteLine("오류 발생");
        }

        public static int PrintProfile(string name, string phone)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력해주삼");
                return -1;
            }
            Console.WriteLine($"이름 : {name}, 폰 번호 : {phone}");
            return 0;
        }
    }
}
