using System;

namespace Chap18App
{
    class StringApp
    {
        string temp2 = "Golbal Variable String";
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습");
            string message1 = null;
            Console.WriteLine($"{message1}");
            string message2 = string.Empty;
            Console.WriteLine($"{message2}");
            string oldPath = "C:\\Program Files\\Bandizip";
            Console.WriteLine($"{oldPath}");
            string newPath = @"C:\Program Files\Bandizip";
            Console.WriteLine($"{newPath}");
            string greeting = "Hello World!";
            var temp1 = "Local Variable String";
            char[] letters = { 'A', 'B', 'C' };
            string hello = new string(letters);
            Console.WriteLine($"{hello}");
            string s1 = "Hello ";
            string s2 = "World!";
            s1 += s2;
            Console.WriteLine($"{s1}");
            string s3 = "Hello ";
            string s4 = s3;
            s3 += "World!";
            Console.WriteLine($"{s4}");

            string row = "Row1\r\nRow2\r\nRow3\r\n";
            Console.Write(row);

            string row2 = "Row11\nRow22\nRow33\n";
            Console.Write(row2);

            Console.Write("Row111" + Environment.NewLine + "Row222" + Environment.NewLine + "Row333\n");
            Console.Write($"Row111{Environment.NewLine}Row222{Environment.NewLine}Row333");

            string oldline = "Test" +
                "Test2" +
                "Test3 ";
            string multiline = @"New Test
These are multiline
end.";
            Console.WriteLine(oldline);
            Console.WriteLine(multiline);
            Console.WriteLine($"\U0001F47D");//\U0001F47D

            var book = (lastName: "박", firstName: "성현", title: "이것이 C#이다.",
                        company: "한빛미디어", releaseDate: "2018-07-01", price: 30000, page: 812);
            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releaseDate).ToString("yyyy-MM-dd")}출간," +
                              $" 페이지수{book.page}, 금액{book.price}");
            string s5 = " COSMos ";
            Console.WriteLine(s5.Trim());
            var s6 = s5.Trim();
            Console.WriteLine(s6.Substring(2,2));
            Console.WriteLine(s6.Replace("C", "C#"));
            Console.WriteLine(s6.Length);
            Console.WriteLine(s6.IndexOf("C"));
            Console.WriteLine(s6.ToLower());
            Console.WriteLine(s6.ToUpper());

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;
            string emptystr2 = "";

            Console.WriteLine(nullstr == emptystr);
            Console.WriteLine(emptystr == emptystr2);

            try
            {
                Console.WriteLine(nullstr.Equals(emptystr));
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외 발생");
            }

            Console.WriteLine(emptystr.Length);
            Console.WriteLine(nullstr.Length);
        }
    }
}
