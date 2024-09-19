//входни данни
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

//проверка кое е по-голямото число
if (firstNumber >= secondNumber)
{
    Console.WriteLine("Greater number: " + firstNumber);
}
else
{
    //противен случай: firstNumber < secondNumber
    Console.WriteLine("Greater number: " + secondNumber);
}
