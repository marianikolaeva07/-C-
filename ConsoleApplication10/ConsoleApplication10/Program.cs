using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            while ()
                {
                a = Console.Write("Введите минимальное число: ");
                a = int.Parse(Console.ReadLine());
                b = Console.Write("Введите максимальное число: ");
                b = int.Parse(Console.ReadLine());
                var sum = 0;
                for (; a <= b; a++)
                {
                    if (a % 2 != 0)
                    {
                        sum += a;
                    }
                }
                Console.WriteLine(sum);
                Console.ReadLine();
            }
        }
    }
}
