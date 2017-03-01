using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey!!! What Is Your Name..");
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();
            if (name == "" && name1 == "")
            {
                Console.WriteLine("Plz Enter");
            }
            else
            {
                Console.WriteLine("Hello!!!{0} and {1} ", name, name1);//Placeholder{0}
                Console.WriteLine("Welcome in C# Solution ");
                Console.WriteLine("What's Going On buddy?");
                string work = Console.ReadLine();
                Console.WriteLine("its Gooood..!!!!!");
            }
            Console.ReadKey();
        }
    }
}
