using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceDifference
{
    class Program
    {
        public static void value(int num)
        {
            num++;
        }
        public static void reference(ref int num)
        {
            num++;
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a numb:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n\tValue type..");
            Console.WriteLine("------------------------");
            Console.WriteLine("\n Previous Values: {0} ",num);
            Program.value(num);
            Console.WriteLine("\nCurrent value : {0}", num);

            Console.WriteLine("\n\n\n-----------------------");
            Console.WriteLine("\t Reference type");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nPrevious value: {0}",num);
            Program.reference(ref num);
            Console.WriteLine("\nCurrent Value: {0}",num);
            Console.ReadKey();

        }
    }
}
