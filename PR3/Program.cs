using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            bool isASet = false, isBSet = false;

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию +");
                Console.WriteLine("4. Выполнить операцию -");
                Console.WriteLine("5. Выполнить операцию *");
                Console.WriteLine("6. Выполнить операцию /");
                Console.WriteLine("7. Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите значение A: ");
                        a = double.Parse(Console.ReadLine());
                        isASet = true;
                        break;
                    case "2":
                        Console.Write("Введите значение B: ");
                        b = double.Parse(Console.ReadLine());
                        isBSet = true;
                        break;
                    case "3":
                        if (isASet && isBSet)
                        {
                            double result = a + b;
                            Console.WriteLine($"Результат {a} + {b} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Сначала введите A и B.");
                        }
                        break;
                    case "4":
                        if (isASet && isBSet)
                        {
                            double result = a - b;
                            Console.WriteLine($"Результат {a} - {b} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Сначала введите A и B.");
                        }
                        break;
                    case "5":
                        if (isASet && isBSet)
                        {
                            double result = a * b;
                            Console.WriteLine($"Результат {a} * {b} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Сначала введите A и B.");
                        }
                        break;
                    case "6":
                        if (isASet && isBSet && b != 0)
                        {
                            double result = a / b;
                            Console.WriteLine($"Результат {a} / {b} = {result}");
                        }
                        else if (b == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль.");
                        }
                        else
                        {
                            Console.WriteLine("Сначала введите A и B.");
                        }
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
