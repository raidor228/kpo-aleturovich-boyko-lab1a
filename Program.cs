using System;

namespace Lab1a
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Рассчитать средний балл");
                Console.WriteLine("2. Генератор пароля");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        new GradeCalculator().Run();
                        break;
                    case "2":
                        new PasswordGenerator().Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }
    }
}