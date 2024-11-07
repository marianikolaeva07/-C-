using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Мишка собирает шишки";
            string w = string.Empty;
            string[] w = s.Split(" ");
            for (int i = 0; i < w.Length; i++)
                if (w[i].Lenght > w.Length)
                    w = w[i];
            Console.WriteLine(w);


        }
    }
}
