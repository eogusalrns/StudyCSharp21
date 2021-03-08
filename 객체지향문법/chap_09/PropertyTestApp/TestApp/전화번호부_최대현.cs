using System;
using System.Collections.Generic;
using TestApp;
//2021-02-26 최대현 전화번호부
namespace TestApp
{
    class addrlist
    {
        public string Name { get; set; }//프로퍼티
        public string Phone { get; set; }
        public string Addr { get; set; }

        /*        public addrlist(string name, string phone, string addr)
                {
                    this.Name = name;
                    this.Phone = phone;
                    this.Addr = addr;
                }*/
    }
}
    class Program
    {
        public static List<addrlist> arrayaddr = new List<addrlist>();
        public static void MainLoop()
        {
            while (true)
            {
                Console.Clear();
                PrintMenu();
                //int number = -1;
                Console.WriteLine("메뉴를 선택하세요");
                bool result = int.TryParse(Console.ReadLine(), out int number);
                //bool number = NumberMenu();
            if (result)
            {
                switch (number)
                {
                    case 0:
                        Input();
                        break;
                    case 1:
                        Search();
                        break;
                    case 2:
                        Modify();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        All_Search();
                        break;
                    case 5:
                        End();
                        break;
                    default:
                        Console.WriteLine("다시 입력");
                        break;
                }
            }
            else
                Console.WriteLine("예외 처리 오류");
/*            if (number == 0)
            {
                Input();
            }
            else if (number == 1)
            {
                Search();
            }
            else if (number == 2)
            {
                Modify();
            }
            else if (number == 3)
            {
                Delete();
            }
            else if (number == 4)
            {
                All_Search();
            }
            else if (number == 5)
            {
                End();
            }
            else
            {
                Console.WriteLine("다시입력");
                break;
            }*/
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체출력");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("------------------");
        }

        public static object NumberMenu()
        {
            int number = -1;
            Console.WriteLine("메뉴를 선택하세요");
            bool result = int.TryParse(Console.ReadLine(), out number);
            return result;
        }
        public static void Input()
        {
            Console.Clear();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            Console.Write("전화 입력: ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력: ");
            string address = Console.ReadLine();
            addrlist addr = new addrlist();
            addr.Name = name;
            addr.Phone = phone;
            addr.Addr = address;
            arrayaddr.Add(addr);
            /*Console.Clear();
            Console.Write("이름 입력: ");
            Name = Console.ReadLine();
            Console.Write("전화 입력: ");
            Phone = Console.ReadLine();
            Console.Write("주소 입력: ");
            Addr = Console.ReadLine();*/
        }

        public static void Search()
        {
            Console.Clear();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();

            for (int i = 0; i < arrayaddr.Count; i++)
            {
                if (name == arrayaddr[i].Name)
                {
                    Console.WriteLine($"-----------{i+1}번째 데이터----------------");
                    Console.WriteLine($"이름 : {arrayaddr[i].Name}");
                    Console.WriteLine($"전화 : {arrayaddr[i].Phone}");
                    Console.WriteLine($"주소 : {arrayaddr[i].Addr}");
                    Console.WriteLine("----------------------------------------");
                    break;
                }
            }
        Console.WriteLine("검색을 종료하시려면 아무 키나 입력하세요");
        Console.ReadKey();
            /*Console.Write("이름 입력: ");
            string x = Console.ReadLine();
            Console.WriteLine("------------------------");
            if (Name == x)
            {
                Console.WriteLine($"이름 : {Name}");
                Console.WriteLine($"전화 : {Phone}");
                Console.WriteLine($"주소 : {Addr}");
            */
        }

        public static void Modify()
        {
            Console.Clear();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();

            for (int i = 0; i < arrayaddr.Count; i++)
            {
                if (name == arrayaddr[i].Name)
                {
                    Console.WriteLine($"-----------{i+1}번째 데이터----------------");
                    Console.WriteLine($"이름 : {arrayaddr[i].Name}");
                    Console.WriteLine($"전화 : {arrayaddr[i].Phone}");
                    Console.WriteLine($"주소 : {arrayaddr[i].Addr}");
                    Console.WriteLine("----------------------------------------");
                    Console.Write("이름 입력: ");
                    string aname = Console.ReadLine();
                    Console.Write("전화 입력: ");
                    string phone = Console.ReadLine();
                    Console.Write("주소 입력: ");
                    string address = Console.ReadLine();
                    arrayaddr[i].Name = aname;
                    arrayaddr[i].Phone = phone;
                    arrayaddr[i].Addr = address;
                    break;
                }
            }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("수정을 종료하시려면 아무 키나 입력하세요");
        Console.ReadKey();
        }
        public static void Delete()
        {
            Console.Clear();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();

            for (int i = 0; i < arrayaddr.Count; i++)
            {
                if (name == arrayaddr[i].Name)
                {
                    Console.WriteLine($"-----------{i+1}번째 데이터----------------");
                    Console.WriteLine($"이름 : {arrayaddr[i].Name}");
                    Console.WriteLine($"전화 : {arrayaddr[i].Phone}");
                    Console.WriteLine($"주소 : {arrayaddr[i].Addr}");
                    Console.WriteLine("----------------------------------------");
                    arrayaddr.RemoveAt(i);
                    break;
                }
            }
        Console.WriteLine("삭제를 종료하시려면 아무 키나 입력하세요");
        Console.ReadKey();
        }

        public static void All_Search()
        {
            Console.Clear();
            for (int i = 0; i < arrayaddr.Count; i++)
            {
                Console.WriteLine($"-----------{i+1}번째 데이터----------------");
                Console.WriteLine($"이름 : {arrayaddr[i].Name}");
                Console.WriteLine($"전화 : {arrayaddr[i].Phone}");
                Console.WriteLine($"주소 : {arrayaddr[i].Addr}");
                Console.WriteLine("----------------------------------------");
            }
        Console.WriteLine("전체 검색을 종료하시려면 아무 키나 입력하세요");
        Console.ReadKey();
        }

        public static void End()
        {
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            MainLoop();
        }
    }