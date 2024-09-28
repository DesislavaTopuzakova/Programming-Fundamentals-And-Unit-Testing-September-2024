//break -> оператор, който прекратява switch, for, while

for (int number = 1; number <= 100; number++)
{
    Console.WriteLine(number);
    if (number == 7)
    {
        break;
    }
}



while (true)
{
    int number = int.Parse(Console.ReadLine());

    if (number % 2 != 0)
    {
        Console.WriteLine(number);
        break;
    }
}

