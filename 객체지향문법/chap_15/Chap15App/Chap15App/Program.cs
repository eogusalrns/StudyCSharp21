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

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Profile> profiles = new List<Profile>
            {
                new Profile() { Name = "홍길동1", Height = 171 },
                new Profile() { Name = "홍길동2", Height = 182 },
                new Profile() { Name = "홍길동3", Height = 183 },
                new Profile() { Name = "홍길동4", Height = 184 },
                new Profile() { Name = "홍길동5", Height = 185 }
            };

            List<Product> products = new List<Product>
            {
                new Product() { Title = "비트", Star = "홍길동1"},
                new Product() { Title = "비트코", Star = "홍길동2"},
                new Product() { Title = "비트인", Star = "홍길동3"},
                new Product() { Title = "비프", Star = "홍길동4"},
                new Product() { Title = "비츠", Star = "홍길동5"}
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
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.InchHeight}inch");
            }
            var resProfile3 = from item in profiles
                              orderby item.Height
                              group item by item.Height < 175 into g
                              select new
                              {
                                  GroupKey = g.Key, Items = g
                              };
            foreach (var group in resProfile3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");
                foreach (var item in group.Items)
                {
                    Console.WriteLine($" {item.Name},{item.Height}");
                }
            }
            //inner join
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star
                               select new
                               {
                                   Name = p.Name,
                                   Work = d.Title,
                                   Height = p.Height * 0.393
                               };
            Console.WriteLine("내부 조인 결과");
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}inch");
            }

            //outer join
            var joinProfiles2 = from p in profiles
                                join d in products
                                on p.Name equals d.Star into ps
                                from d2 in ps.DefaultIfEmpty(new Product() { Title="작품없음"})
                                select new
                                {
                                    Name = p.Name,
                                    Work = d2.Title,
                                    Height = p.Height * 0.393
                                };
            Console.WriteLine("외부 조인 결과");
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}inch");
            }
        }
    }
}
