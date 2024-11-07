using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;


namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №1";                   
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("Практическая работа №1");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("Знакомство со средой программирования С#");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("Выполнили студенты группы Ип1-21");
            Console.SetCursorPosition(28, 8);
            Console.WriteLine("Абрашкина Дарья Васильевна");
            Console.SetCursorPosition(28, 9);
            Console.WriteLine("Николаева Мария Романовна");
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("Вариант 1");
            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            Console.Title = "Задание №1";
            Console.SetCursorPosition(30, 5);
            Console.WriteLine(@"Условие задачи №1
                   Запустить при нажатии любой клавиши
                    стандартное приложение Калькулятор


                   Для запуска калькулятора нажмите любую клавишу");
            Process.Start("C:\\Windows\\system32\\calc.exe");
            Console.ReadKey();
            Console.Clear();
            Console.Title = "Задание №2";
            Console.SetCursorPosition(30, 5);
            Console.WriteLine(@"Условие задачи №2
                   Познакомиться с некоторыми способами 
                    повышения эффективности работы 
                    в среде Visual Studio


                    Для завершения нажмите любую клавишу");
    Console.ReadKey();

            {

                }              
            {

            }
        }
    }
}
