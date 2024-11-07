using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
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
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                a[i] = rn.Next(-10, 10);
                Console.Write("{0,5}", a[i]);
            }
            for (int i = 1; i < n; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            Console.WriteLine("\nМаксимальное число: ");
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
