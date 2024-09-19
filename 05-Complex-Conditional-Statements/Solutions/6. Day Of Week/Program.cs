//входни данни
int number = int.Parse(Console.ReadLine());

//SWITCH конструкция
//серия от проверки за въведеното число за точни стойности
//само една проверка да е вярна
//1 -> Monday
//2 -> Tuesday
//3 -> Wednesday
//4 -> Thursday
//5 -> Friday
//6 -> Saturday
//7 -> Sunday

switch (number)
{
    case 1:
        Console.WriteLine("Monday");
        break; //прекратява switch конструкция
    case 2:
        Console.WriteLine("Tuesday");
        break; //прекратява switch конструкция
    case 3:
        Console.WriteLine("Wednesday");
        break; //прекратява switch конструкция
    case 4:
        Console.WriteLine("Thursday");
        break; //прекратява switch конструкция
    case 5:
        Console.WriteLine("Friday");
        break; //прекратява switch конструкция
    case 6:
        Console.WriteLine("Saturday");
        break; //прекратява switch конструкция
    case 7:
        Console.WriteLine("Sunday");
        break; //прекратява switch конструкция
    default:
        //нито едно от горните условия не е било вярно
        Console.WriteLine("Error");
        break; //прекратява switch конструкция
}
