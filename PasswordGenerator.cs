using System;
using System.Text;

namespace Lab1a;

public class PasswordGenerator
{
    public void Run()
    {
        Console.Write("Введите длину пароля: ");

        if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
        {
            Console.WriteLine("Некорректная длина.");
            return;
        }

        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%";
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        Console.WriteLine($"Сгенерированный пароль: {password}");
    }
}