using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15App
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Profile> profiles = new List<Profile>
            {
                new Profile() { Name = "홍길동1", Height = 181 },
                new Profile() { Name = "홍길동2", Height = 182 },
                new Profile() { Name = "홍길동3", Height = 183 },
                new Profile() { Name = "홍길동4", Height = 184 },
                new Profile() { Name = "홍길동5", Height = 185 }
            };

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height
                              select new
                              {
                                  Name = item.Name,
                                  Height = item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.InchHeight}");
            }
        }
    }
}
