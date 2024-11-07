using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, d;
            Console.WriteLine("Введите коэффициенты: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d < 0)
            {
                    Console.WriteLine("Нет корней");
        }
            else 
{
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x1);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x2);
            }
            Console.ReadKey();
        }
    }
}
