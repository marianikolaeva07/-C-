using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("Введите название месяца: ");
            x = Convert.ToString(Console.ReadLine());
            switch (x)
            {
                case "Декабрь":
                    Console.WriteLine("Зима");
                    break;
                case "Январь":
                    Console.WriteLine("Зима");
                    break;
                case "Февраль":
                    Console.WriteLine("Зима");
                    break;
                case "Март":
                    Console.WriteLine("Весна");
                    break;
                case "Апрель":
                    Console.WriteLine("Весна");
                    break;
                case "Май":
                    Console.WriteLine("Весна");
                    break;
                case "Июнь":
                    Console.WriteLine("Лето");
                    break;
                case "Июль":
                    Console.WriteLine("Лето");
                    break;
                case "Август":
                    Console.WriteLine("Лето");
                    break;
                case "Сентябрь":
                    Console.WriteLine("Осень");
                    break;
                case "Октябрь":
                    Console.WriteLine("Осень");
                    break;
                case "Ноябрь":
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}
