using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1a;

public class GradeCalculator
{
    public void Run()
    {
        Console.WriteLine("Введите оценки через пробел:");

        string input = Console.ReadLine();

        try
        {
            List<double> grades = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            if (grades.Count == 0)
            {
                Console.WriteLine("Оценки не введены.");
                return;
            }

            double average = grades.Average();
            Console.WriteLine($"Средний балл: {average:F2}");
        }
        catch
        {
            Console.WriteLine("Ошибка ввода. Введите числа через пробел.");
        }
    }
}