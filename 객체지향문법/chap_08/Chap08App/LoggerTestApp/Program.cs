using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message} ");
        }
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleFormatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그메시지");

            IFormattableLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12);
        }
    }
}
