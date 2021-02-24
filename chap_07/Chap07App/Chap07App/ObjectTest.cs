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
        }
    }

    class Cat
    {
        public Cat(){}
        public Cat(string _name,string _color)
        {
            Name = _name;
            Color = _color;
        }
        public string Name;//이름
        public string Color;//색상
        
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
}
