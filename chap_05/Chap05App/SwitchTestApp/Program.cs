using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("요일 입력하세요 : ");
            string line = Console.ReadLine();
            string day = line;

            switch (day)
            {
                case "월요일":
                    Console.WriteLine("월요일조아");
                    break;
                case "화요일":
                    Console.WriteLine("화요일하드발탄");
                    break;
                case "수요일":
                    Console.WriteLine("수요일로아업뎃");
                    break;
                case "목요일":
                    Console.WriteLine("졸업식대여마감");
                    break;
                case "금요일":
                    Console.WriteLine("불금꿀잠각");
                    break;
                case "토요일":
                    Console.WriteLine("나만의로요일");
                    break;
                case "일요일":
                    Console.WriteLine("내일부터평일");
                    break;
                default:
                    Console.WriteLine("요일이 아니무니다");
                    break;
            }
        }
    }
}
