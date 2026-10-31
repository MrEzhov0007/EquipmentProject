using System;
using System.Collections.Generic;

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

        Console.WriteLine("Список оборудования:");
        foreach (string item in equipment)
        {
            Console.WriteLine(item);
        }
    }
}