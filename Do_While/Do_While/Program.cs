using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            do
            {
                Console.WriteLine("values of a: {0}",a);
                a=a+1;
            }
            while(a<20);
            Console.ReadKey();
        }
    }
}
