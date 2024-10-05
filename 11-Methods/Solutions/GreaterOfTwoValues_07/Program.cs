string type = Console.ReadLine();
//тип на данните, които ще сравняваме: "int", "string", "char"
PrintGreaterValue(type);



//----------------------------------------------------------
//метод, който отпечатва по-голямата стойност
static void PrintGreaterValue (string type)
{
    //проверка кой тип данни е въведен за сравнение -> отпечатваме по-голямата стойност
    switch (type)
    {
        case "int":
            //сравнение на две цели числа
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
            break;
        case "string":
            //сравнение на два текста
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();
            //String.Compare сравнява два текста по големина
            //0 -> двата текста са еднакви
            //1 -> firstText е след secondText
            //-1 -> firstText е преди secondText
            if (String.Compare(firstText, secondText) >= 0)
            {
                Console.WriteLine(firstText);
            }
            else
            {
                //String.Compare(firstText, secondText) < 0
                Console.WriteLine(secondText);
            }
            break;
        case "char":
            //сравнение на два символа
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            if (firstSymbol <= secondSymbol)
            {
                Console.WriteLine(secondSymbol);
            }
            else
            {
                Console.WriteLine(firstSymbol);
            }
            break;
    }
}