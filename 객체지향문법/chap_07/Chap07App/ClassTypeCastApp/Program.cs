using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍()");
        }
    }
    
    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹이다옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            _포유류 = new 강아지();
            _포유류.키우다();
            강아지 츄츄;
            if ( _포유류 is 강아지)
            {
                츄츄 = _포유류 as 강아지;
                츄츄.멍멍();
            }
            /*
            ((강아지)_포유류).멍멍();
            _포유류 = new 고양이();*/
            /*
                        _포유류 = new 강아지();

                        _포유류 = new 고양이();*/
            //_포유류.야옹();안됨 부모클래스에 야옹없음

            강아지 뽀삐 = null;
            if (뽀삐 is 포유류)
            {
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }
            /*
            강아지 뽀삐 = (강아지) new 포유류();// 부모 -> 자식 클래스 형변환은 불가능
            //뽀삐.멍멍();
            뽀삐.키우다();
            고양이 로미 = (고양이) new 포유류();
            //로미.야옹();
            로미.키우다();
*/
        }
    }
}
