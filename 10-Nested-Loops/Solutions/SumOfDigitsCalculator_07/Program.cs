//while цикъл
//повтаряме: въвеждаме входни данни (число под формата на текст или "End")
//стоп: входни данни == "End"
//продължаваме: входни данни != "End"

string input = Console.ReadLine();

while (input != "End")
{
    //input = "99" -> число, което е под формата на текст
    //"99" string -> 99 int
    int number = int.Parse(input); //въведеното цяло число -> 286
    int sumDigits = 0; //сума от цифрите

    //продължаваме: umber > 0 -> има цифри в числото
    //стоп: number <= 0 -> нямаме цифри в числото

    while (number > 0) //докато има цифри в числото
    {
        //1. взимам последната цифра
        int lastDigit = number % 10;
        //2. добавям цифрата към сумата
        sumDigits += lastDigit;
        //3. премахвам последната цифра
        number /= 10;
    }

    //нямаме цифри в числото -> знаем сумата от цифрите
    Console.WriteLine("Sum of digits = " + sumDigits);

    //въвеждам нови входни данни
    input = Console.ReadLine();
}

Console.WriteLine("Goodbye");





