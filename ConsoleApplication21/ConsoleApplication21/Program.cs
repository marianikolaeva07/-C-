using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Мишка собирает шишки";
            string w = string.Empty;
            string[] a = s.Split(' ');
            for (int i = 0; i < a.Length; i++)
                if (a[i].Length > w.Length)
                    w = a[i];
            Console.WriteLine(w);
        }
    }
}
