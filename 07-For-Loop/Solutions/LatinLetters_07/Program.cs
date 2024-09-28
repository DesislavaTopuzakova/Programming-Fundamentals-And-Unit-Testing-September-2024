//входни данни
char startSymbol = char.Parse(Console.ReadLine()); //символ, който е начало на диапазона
char endSymbol = char.Parse(Console.ReadLine()); //символ, който е край на диапазона

//всеки символ от startSymbol до endSymbol -> отпечатвам го и слагам интервал след него
//повтаряне на действие определен брой пъти -> for цикъл

//1. начало -> startSymbol
//2. край -> endSymbol
//3. повтаряме -> отпечатваме символа и след това интервал
//4. промяна -> +1

for (char symbol = startSymbol; symbol <= endSymbol; symbol++)
{
    Console.Write(symbol + " ");
}