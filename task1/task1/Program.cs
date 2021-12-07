using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Калькулятор
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;


            Console.WriteLine("Введите первое целое число");
            try
            {
                a = (Convert.ToInt32(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }

            Console.WriteLine("Введите второе целое число");
            try
            {
                b = (Convert.ToInt32(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }

            Console.WriteLine("Введите код операции:");
            Console.WriteLine("1 – сложение");
            Console.WriteLine("2 – вычитание");
            Console.WriteLine("3 – произведение");
            Console.WriteLine("4 – частное");
            int operation = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Результат операции:");
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine(a + b);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(a - b);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(a * b);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            Console.WriteLine(a / b);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка! Неправильный код!");
                        break;
                    };
            }

            Console.ReadKey();
        }
    }
}
