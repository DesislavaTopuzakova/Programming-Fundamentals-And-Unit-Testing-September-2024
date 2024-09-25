int number = int.Parse(Console.ReadLine());

for (int multiplier = 1; multiplier <= 100; multiplier++)
{
    int result = number * multiplier;
    Console.WriteLine(number + " * " + multiplier + " = " + result);
}

