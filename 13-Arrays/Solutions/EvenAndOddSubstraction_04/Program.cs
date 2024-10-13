//1. прочитаме масив от цели числа от конзолата
int[] numbers = Console.ReadLine() //"1 2 3 4 5 6"
                .Split(" ")        //["1", "2", "3", "4", "5", "6"]
                .Select(int.Parse) //[1, 2, 3, 4, 5, 6]
                .ToArray();

//2. намираме сумата на четните числа в масива
int sumEven = 0;

//3. намираме сумата на нечетните числа в масива
int sumOdd = 0;

//обхождаме елементите в масива -> проверка дали е четно / нечетно и след това го добавяме
foreach(int number in numbers)
{
    if (number % 2 == 0)
    {
        //number е четно число
        sumEven += number;
    }
    else
    {
        //number е нечетно число
        sumOdd += number;
    }
}

//след обхождането на всички елементи: сумата на четните числа и сумата на нечетните числа
int diff = sumEven - sumOdd;
Console.WriteLine(diff);