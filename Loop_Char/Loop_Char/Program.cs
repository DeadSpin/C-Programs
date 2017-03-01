using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = (char)65; i < (char)91; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
