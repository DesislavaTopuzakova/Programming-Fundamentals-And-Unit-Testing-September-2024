int countNumbers = int.Parse(Console.ReadLine()); //брой на числата, които ще ми се въвеждат

int[] numbers = new int[countNumbers];

//попълваме масива с числа
for (int number = 1; number <= countNumbers; number++)
{
    //обхождаме всяко едно число от първото до последното:
    //1. въвеждам неговата стойност
    int value = int.Parse(Console.ReadLine());
    //2. добавям в масива
    numbers[number - 1] = value;
}


//обхождаме масива в обратен ред
//numbers = [10, 20, 30]
for (int position = numbers.Length - 1; position >= 0; position--)
{
    Console.Write(numbers[position] + " ");
}