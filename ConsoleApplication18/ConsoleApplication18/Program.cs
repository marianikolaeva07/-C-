using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int[] elementsOnMainDiagonal = new int[n];

            Random rn = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rn.Next(-3, 3);
                    if (i == j)
                    {
                        elementsOnMainDiagonal[i] = array[i, j];
                    }
                }
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                    if (j == n - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Среднее арифметическое элементов главной диагонали: "
                + elementsOnMainDiagonal.Average());

            Console.WriteLine("Новый массив с неотрицательными элементами: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Math.Abs(array[i, j]);
                    if (i == j)
                    {
                        elementsOnMainDiagonal[i] = array[i, j];
                    }
                }
            }
            Console.WriteLine("Среднее арифметическое изменённых элементов главной диагонали: "
                + elementsOnMainDiagonal.Average());
        }
    }
}