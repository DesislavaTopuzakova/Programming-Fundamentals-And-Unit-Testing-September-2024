//входни данни
int startNumber = int.Parse(Console.ReadLine()); //начало на интервала
int endNumber = int.Parse(Console.ReadLine()); //край на интервала

//всички числа от startNumber до endNumber
//повтарящо се действие определен брой пъти -> !!!!цикъл!!!! -> for цикъл

//1. начало -> startNumber
//2. край -> endNumber
//3. повтаряме -> отпечатваме
//4. промяна -> +1


//обикновен for цикъл -> променливата се увеличава с 1
for (int number = startNumber; number <= endNumber; number++)
{
    Console.WriteLine(number);
}
