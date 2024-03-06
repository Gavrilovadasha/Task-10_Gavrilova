using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        char x1 = (char)('a' + random.Next(8));
        int y1 = random.Next(1, 9);

        char x2 = (char)('a' + random.Next(8));
        int y2 = random.Next(1, 9);

        Console.WriteLine("Введите название фигуры, расположенной на поле x1y1");
        string? figure = Console.ReadLine();

        Console.WriteLine($"Координаты первого поля: {x1}{y1}");
        Console.WriteLine($"Координаты второго поля: {x2}{y2}");

        switch (figure)
        {
            case "ладья":
                if (x1 != x2 && y1 != y2)
                    Console.WriteLine("Ладья не угрожает второму полю.");
                else
                    Console.WriteLine("Ладья угрожает второму полю.");
                break;
            case "слон":
                int diffX = Math.Abs(x1 - x2);
                int diffY = Math.Abs(y1 - y2);
                if (diffX != diffY)
                    Console.WriteLine("Слон не угрожает второму полю.");
                else
                    Console.WriteLine("Слон угрожает второму полю.");
                break;
            case "король":
                int diffX2 = Math.Abs(x1 - x2);
                int diffY2 = Math.Abs(y1 - y2);
                if (diffX2 <= 1 && diffY2 <= 1)
                    Console.WriteLine("Король может попасть на второе поле одним ходом.");
                else
                    Console.WriteLine("Король не может попасть на второе поле одним ходом.");
                break;
            case "ферзь":
                if (x1 != x2 && y1 != y2 && Math.Abs(x1 - x2) != Math.Abs(y1 - y2))
                    Console.WriteLine("Ферзь не угрожает второму полю.");
                else
                    Console.WriteLine("Ферзь угрожает второму полю.");
                break;
            default:
                Console.WriteLine("Некорректное название фигуры.");
                break;
        }
    }
}
