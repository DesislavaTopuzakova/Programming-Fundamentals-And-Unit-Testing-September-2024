PrintText();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

PrintText();
int numberInRange = 5;
if (numberInRange > 2)
{
    Console.WriteLine(numberInRange);
}

PrintText();
while (numberInRange < 10)
{
    numberInRange--;
    PrintText();
}
PrintText();

//-------------------------------------------------------
//метод, в който ще съхраняваме нашата поватаряща команда
//при създаване на метод:
//1. static
//2. вид на метода: void / връща стойност
//3. име на метод: EN, Pascal Case, какво прави този метод?
//4. параметри ()
static void PrintText()
{
    Console.WriteLine("Hello, Softuni");
    Console.WriteLine("Hello, Sofia!");
    Console.WriteLine("Hello, Desi!");
}


