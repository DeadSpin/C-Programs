using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Ur No. ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 20)
            {
                Console.WriteLine("a is less than 20");
            }
            else
            {
                Console.WriteLine("a is greater than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadKey();
        }
    }
}
