int n = int.Parse(Console.ReadLine());


//For цикъл
//поватаряме: отпечатваме 2 на степен
//начало: 0
//край: n
//промяна: +2

//for цикъл със стъпка
for (int power = 0; power <= n; power += 2)
{
    Console.WriteLine(Math.Pow(2, power));
}