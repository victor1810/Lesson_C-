int number1 = new Random().Next(1, 100);
int number2 = new Random().Next(1, 100);

if (number1 > number2)
    Console.Write($"number1 = {number1}, number2 = {number2}. Вывод ->  {number1} > {number2}");
else
    Console.Write($"number1 = {number1}, number2 = {number2}. Вывод ->  {number2} > {number1}");