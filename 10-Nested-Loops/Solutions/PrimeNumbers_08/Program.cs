//входни данни

int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

//всяко число в диапазона [startNumber; endNumber]

for (int number = startNumber; number <= endNumber; number++)
{
    //числото е съхранено в number
    //1. намираме брой на делителите
    int count = 0; //броя на делителите на числото number
    for (int divisor = 1; divisor <= number; divisor++)
    {
        if (number % divisor == 0)
        {
            //divisor е делител на number
            count++;
        }
    }
    //знаем броя на делителите -> count

    //2. проверка за просто число
    //просто число: има точно два делителя (1 и самото число)
    if (count == 2)
    {
        //number е просто число
        Console.Write(number + " ");
    }
}

