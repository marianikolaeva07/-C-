using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double x, y, a, b;
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            x = a;
            do
            {
                y = Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 3 * x - 4;
                Console.WriteLine("{0,5:##0.00} | {0,5:##0.00}", x, y);
                x += 0.5;
                Console.Write("Значение функции: ");
                Console.WriteLine(y);
            }
            while (x <= b);

        }
    }
}
