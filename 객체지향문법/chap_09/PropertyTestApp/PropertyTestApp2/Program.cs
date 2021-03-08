using System;

namespace PropertyTestApp2
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
/*        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();
            /*info.SetName("홀길동");
            info.SetBirthday(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthday()}");*/
            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순";
            info2.Birthday = new DateTime(1992, 3, 16);
            Console.WriteLine($"이름 : {info2.Name}");
            Console.WriteLine($"생일 : {info2.Birthday}");
        }
    }
}
