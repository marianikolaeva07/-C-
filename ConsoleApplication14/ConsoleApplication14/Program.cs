using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a * a * a;
            Console.WriteLine(b);

        }
    }
}
