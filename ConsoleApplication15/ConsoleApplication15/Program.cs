using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива ");
            int n = Convert.ToInt32(Console.ReadLine());

            int pr = 1;
            int[] a = new int[n];
            Random rn = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = rn.Next(-20, 20);
                Console.Write("{0,5}", a[i]);
                if (a[i] < 0 && a[i] % 2 != 0) pr = pr * a[i];
            }
            Console.WriteLine("\nПроизведение отрицательных элементов {0}", pr);
            Console.ReadKey();
        }
    }
}
