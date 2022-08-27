Console.Write("\nВведите число: ");
int numbers = int.Parse(Console.ReadLine());
int count = 1;

while (count < 11)
{
    Console.WriteLine($"{numbers} x {count} = " + numbers * count);
    count++;
}
