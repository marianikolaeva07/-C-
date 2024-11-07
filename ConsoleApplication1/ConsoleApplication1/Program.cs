using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите с: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            float e = (a + b + c) / d;
            Console.WriteLine("(a+b+c)/d =" + e);
            Console.ReadKey();
        }
    }
}
