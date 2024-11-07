using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, r;
            Console.Write("Введите координату x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите радиус круга:  ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x * x + y * y <= r * r ? "Внутри круга" : "вне круга");
            Console.ReadKey();
        }
    }
}
