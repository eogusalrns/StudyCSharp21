using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("냥1","색1");
            cat1.Name = "떼껄룩";
            cat1.Color = "검은색";
            cat1.Meow();

            Cat kitty = new Cat("냥2","색2");
            kitty.Name = "헬로키티";
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat("냥3","색3");
            nero.Name = "검은고양이 네로";
            nero.Color = "검은";
            nero.Meow();

            Cat mooyaho = new Cat("냥","냥");
            mooyaho.Meow();

            Cat yomi = new Cat("냥", "냥냥", "냥냥냥");
            yomi.Meow();
        }
    }

    class Cat
    {
        public Cat(){}
        public Cat(string Name)
        {
            this.Name = Name;
        }
        public Cat(string Name,string Color) : this(Name)
        {
            //this.Name = Name;
            this.Color = Color;
        }
        public Cat(string Name,string Color,string Gender) :this(Name,Color)
        {
            //this.Name = Name;
            //this.Color = Color;
            this.Gender = Gender;
        }
        public string Name;//이름
        public string Color;//색상
        public string Gender;//성별
        
        public void Meow()
        {
            Console.WriteLine($"{Name} / {Color} / {Gender} : 야옹");
        }
    }
}
