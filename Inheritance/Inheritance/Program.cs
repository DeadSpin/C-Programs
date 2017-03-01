using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Item
    {
        public void company()
        {
            Console.WriteLine("Item Code=123");
        }

    }
    class fan : Item
    {
        public void model()
        {
            Console.WriteLine("Fan model = classic");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fan f = new fan();
            f.company();
            f.model();
            Console.Read();
        }
    }
}
