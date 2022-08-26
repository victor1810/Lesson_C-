int number = 0;
int b = 0;
Console.Write("Введите числои степень: ");

if (int.TryParse(Console.ReadLine(), out number) && int.TryParse(Console.ReadLine(), out b))
    Console.Write($"sqr of {number, b});

Console.Write($"numbers = {numbers * numbers}");