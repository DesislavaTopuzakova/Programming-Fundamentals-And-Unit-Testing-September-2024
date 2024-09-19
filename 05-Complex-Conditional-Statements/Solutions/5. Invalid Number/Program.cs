//входни данни
int number = int.Parse(Console.ReadLine());

bool isValid = (number >= 100 && number <= 200) || number == 0;
//isValid = true -> числото е валидно
//isValid = false -> числото не е валидно

//невалидно число -> отпечатваме текста "invalid"

//isValid = true -> валидно число -> !isValid = false
//isValid = false -> невалидно число -> !isValid = true
if (!isValid)
{
    Console.WriteLine("invalid");
}