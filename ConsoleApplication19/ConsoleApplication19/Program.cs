using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s.Replace(" ", "");
            char[] a = s.ToCharArray();
            char[] b = s.ToCharArray();
            Array.Reverse(a);
            if (new string(a) == new string(b))
                Console.WriteLine("Это перевертыш");
            else
                Console.WriteLine("Это не перевертыш");
        }
    }
}
