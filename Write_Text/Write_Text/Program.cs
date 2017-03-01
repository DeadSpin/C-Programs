using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Write_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tw = File.CreateText("C:\\Users\\sony\\Desktop\\as.txt");
            tw.WriteLine("Hello, World");
            tw.Close();

        }
    }
}
