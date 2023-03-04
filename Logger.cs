using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogger
{
    internal class Logger
    {
        public void Log(string text)
        {
            Console.BackgroundColor= ConsoleColor.DarkGreen;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine(text);
            Console.BackgroundColor = default;
            Console.ForegroundColor = default;
        }
    }
}
