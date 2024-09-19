//входни данни
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int biggestNumber = 0; //най-голямото число

// първото число е най-голямо
if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
{
    biggestNumber = firstNumber;
}
// второто число е най-голямо
else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
{
    biggestNumber = secondNumber;
}
//третото число е най-голямо
else
{
    biggestNumber = thirdNumber;
}

//знам кое е най-голямото число
Console.WriteLine(biggestNumber);
