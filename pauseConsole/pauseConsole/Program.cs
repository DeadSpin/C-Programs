using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pauseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pausing 10 Second");
            System.Threading.Thread.Sleep(10000);
        }
    }
}
