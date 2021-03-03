using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App
{
    class Program
    {
        delegate void ThereIsAFire(string location);

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불났어유. 주소는 {location}이여요.");
        }

        static void ShotOut(string location)
        {
            Console.WriteLine($"불2야. 주소는 {location}에 불남요.");
        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나가야겠어.");
        }

        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(ShotOut);
            fire += Call119;
            fire += Escape;
            fire("상남동");
        }
    }
}
