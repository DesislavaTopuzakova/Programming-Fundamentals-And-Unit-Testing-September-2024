int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//numbers = [5, 3, 6, 3, 4]

int sum = 0; //сумата на числата в масива
//обхождаме всеки един елемент -> сумираме
//вариант 1: с for цикъл
//вариант 2: с foreach цикъл

foreach (int number in numbers)
{
    //number ми се съхранява всяко едно число от масива
    sum += number;
}

//обходили сме всички числа в масива и сме ги сумирали
Console.WriteLine(sum);



