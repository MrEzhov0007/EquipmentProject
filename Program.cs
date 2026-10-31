using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var equipment = new List<string>
        {
            "Монитор",
            "Клавиатура",
            "Мышь",
            "Принтер",
            "Системный блок"
        };

        Console.Write("Введите название оборудования: ");
        string query = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(query))
        {
            Console.WriteLine("Поисковый запрос не может быть пустым.");
            return;
        }

        var results = equipment
            .Where(item => item.Contains(query, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (results.Count == 0)
        {
            Console.WriteLine("Оборудование не найдено.");
            return;
        }

        foreach (string item in results)
        {
            Console.WriteLine(item);
        }
    }
}