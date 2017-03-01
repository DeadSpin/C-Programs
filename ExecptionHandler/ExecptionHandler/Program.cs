using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] demon = { 2, 0, 4, 4, 0, 8 };
            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + "/" + demon[i] + "is" + numer[i] / demon[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cant divide by Zero");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("NO matching element found.");
                }
            }
            Console.ReadKey();
        }
    }
}
