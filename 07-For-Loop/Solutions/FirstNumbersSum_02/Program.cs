//входни данни
int startNumber = 1; //начало на интервала
int endNumber = int.Parse(Console.ReadLine()); //край на интервала

int sum = 0; //сумата на числата в диапазона

//всяко число в интервала [1; endNumber] -> добавям го към сумата
//повтарящо се действие определен брой пъти -> for цикъл

//начало: 1
//край: endNumber
//повтаряме: сумираме числото
//промяна: +1

for (int number = startNumber; number <= endNumber; number++)
{
    //отпечатваме го с плюс след него, ако не е последното
    if (number != endNumber)
    {
        //number не ми е последното в диапазона
        Console.Write(number + "+");
    }
    else
    {
        //number == endNumber => number ми е последното в диапазона
        Console.Write(number + "=");
    }
    
    //добавямe числото към сумата
    sum = sum + number;
}

//преминали през всички числа от диапазона и всяко едно число сме го добавили към сумата
Console.Write(sum);

