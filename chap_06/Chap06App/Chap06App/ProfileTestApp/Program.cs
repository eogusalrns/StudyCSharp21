using System;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile(name:"최대현", phone:"010-8984-7695");

            if (PrintProfile(name: null, phone:"010-1111-2222") == -1)
                Console.WriteLine("오류 발생");
            PrintProfile(name:"최백호",idx:1);
        }

        public static int PrintProfile(int idx=2,string name="홍길동", string phone="010-7979-7979(default)")//디폴트 값 뒤에서부터
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
