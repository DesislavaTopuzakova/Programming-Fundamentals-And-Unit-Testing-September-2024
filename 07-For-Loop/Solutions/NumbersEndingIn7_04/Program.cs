//входни данни
int startNumber = 7; //начало на интервала
int endNumber = int.Parse(Console.ReadLine()); //край на интервала

//всички числа от 7 до endNumber
//повтарящо се действие определен брой пъти -> !!!цикъл!!! -> for цикъл

//1. начало -> 7
//2. край -> endNumber
//3. повтаряме -> отпечатваме 
//4. промяна -> +10

//for цикъл със стъпка -> увеличаване на променливата със стойност различна от 1

//начин 1: цикъл със стъпка
/*for (int number = startNumber; number <= endNumber; number += 10)
{
    Console.WriteLine(number);
}*/

//начин 2: обикновен цикъл
for (int number = startNumber; number <= endNumber; number++)
{
    //проверка дали числото завършва на 7 -> отпечатвам
    if (number % 10 == 7)
    {
        //числото завършва на 7
        Console.WriteLine(number);
    }
}


