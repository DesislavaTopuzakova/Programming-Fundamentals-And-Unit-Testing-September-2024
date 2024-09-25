//входни данни
int startNumber = 1;
int endNumber = int.Parse(Console.ReadLine());

//всички числа от [startNumber; endNumber] през 3
//повтарящо се действие определен брой пъти -> !!!цикъл!!! -> for цикъл

//1. начало -> startNumber = 1
//2. край -> endNumber
//3. повтаряме -> отпечатваме
//4. промяна -> +3

//for цикъл със стъпка -> увеличаването е с повече от 1
for (int number = startNumber; number <= endNumber; number += 3)
{
    Console.WriteLine(number);
}