using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ("Привет, пропан, элементы, Даша, пропасть, Маша");
            string s1 = (s.Substring(5, 1));
            string s2 = (s.Substring(13, 1));
            string s3 = (s.Substring(23, 1));
            string s4 = (s.Substring(29, 1));
            string s5 = (s.Substring(39, 1));
            string s6 = (s.Substring(45, 1));
            Console.Write(s1);
            Console.Write(s2);
            Console.Write(s3);
            Console.Write(s4);
            Console.Write(s5);
            Console.Write(s6);
            Console.ReadKey();
        }
    }
}
