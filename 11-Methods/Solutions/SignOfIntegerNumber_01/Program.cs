int number = int.Parse(Console.ReadLine());

PrintNumberType(number);


//-----------------------------------------
//метод, който отпечатва вида на числото
//1. static
//2. вид на метода
//3. име на метода
//4. параметри

static void PrintNumberType(int number)
{
    if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else
    {
        //num == 0
        Console.WriteLine($"The number {number} is zero.");
    }
}