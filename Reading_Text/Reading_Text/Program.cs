using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Reading_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader tr = File.OpenText(@"‪‪‪‪C:\Users\Dead$piN\Documents\My Docs\My Texts.txt");
            Console.Write(tr.ReadToEnd());
            tr.Close();
            Console.WriteLine("find your Destination");
            Console.Read();
        }
    }
}
