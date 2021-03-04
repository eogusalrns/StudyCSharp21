using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{
    class DataFileManager
    {
        string dataFileName = "address.dat";
        //D:\GitRepository\StudyCSharp21\chap_99\AddressBookApp\AddressBookApp\bin\Debug\netcoreapp3.1
        //Console.WriteLine(Environment.CurrentDirectory);


        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            //텍스트 파일에서 저장된 주소록을 불러온다(로드)
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;
            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                var splits = temp.Split("|");
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();
            return listResult;
        }
        public void WriteData(List<AddressInfo> param)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;
            //주소록을 다시 파일에 씀
            var sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (param.Count > 0)
                foreach (var item in param)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            sw.Close();

        }
    }
}