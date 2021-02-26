using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class Mammal
    { 
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다");
        }
        public virtual void Move()
        {
            Console.WriteLine($"(부모작업) {this.Name}이(가) 이동한다");
        }
    }

    class Dog : Mammal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다.");
        }
    }

    class Human : Mammal
    {
        public new void Move()//new를 쓰면 부모의 메서드 숨긴다.
        {
            Console.WriteLine($"{this.Name}이(가) 두발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        public override void Move()//부모의 메서드 재정의
        {
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 움직인다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
