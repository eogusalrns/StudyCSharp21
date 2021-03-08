using System;

namespace AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                AddressManager manager = new AddressManager();
                //manager.listAddress = new List<AddressInfo>();

                DataFileManager fileManager = new DataFileManager();
                manager.listAddress = fileManager.ReadData();

                while (true)
                {
                    Console.Clear();
                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();
                    switch (menuNum)
                    {
                        case 1://주소입력 화면 전환
                            Console.Clear();
                            manager.InputAddress();
                            break;
                        case 2://주소 검색
                            Console.Clear();
                            manager.SearchAddress();
                            break;
                        case 3://주소 수정
                            Console.Clear();
                            manager.ModifyAddress();
                            break;
                        case 4://주소 삭제
                            Console.Clear();
                            manager.DeleteAddress();
                            break;
                        case 5://주소 전체 출력
                            Console.Clear();
                            manager.PrintAllAddress();
                            break;
                        case 6://프로그램 종료
                            fileManager.WriteData(manager.listAddress);
                            Environment.Exit(0);
                            break;
                        default://메뉴선택 실패, 메뉴로 돌아감
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            finally
            {

            }
        }
    }
}
