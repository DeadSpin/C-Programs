using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Overload
    {
        public void ovlDemo()
        {
            Console.WriteLine("No Parameter");
        }
        public void ovlDemo(int a)
        {
            Console.WriteLine("One Parameter : " + a);//for one int
        }
        public int ovlDemo(int a, int b)
        {
            Console.WriteLine("Two Parameter : " + a + " " + b);//for two int
            return a + b;
        }
        public double ovlDemo(double a, double b)
        {
            Console.WriteLine("Two Double parameter: " + a + " " + b);//for double parameter
            return a + b;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Overload ob = new Overload();
                int resI;
                double resD;//call all version of ovlDemo()
                ob.ovlDemo();
                Console.WriteLine();
                ob.ovlDemo(2);
                Console.WriteLine();
                resI = ob.ovlDemo(4, 6);
                Console.WriteLine("Result of ob.OvlDemo(4,6) : " + resI);
                Console.WriteLine();
                resD = ob.ovlDemo(1.1, 2.32);
                Console.WriteLine("Result of ob.ovlDemo(1.1,2.32): " + resD);
                Console.ReadLine();
            }
        }
    }
}
