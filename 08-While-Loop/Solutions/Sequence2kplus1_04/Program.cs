//входни данни
int n = int.Parse(Console.ReadLine());

//всички числа 1 до n и да ги отпечатаме

//For цикъл
//начало: 1
//край: n
//повтаряме: отпечатваме
//промяна: * 2 + 1
for (int number = 1; number <= n; number = number * 2 + 1)
{
    Console.WriteLine(number);
}

//While цикъл
/*int number = 1;
while (number <= n)
{
    Console.WriteLine(number);
    number = number * 2 + 1;
}*/