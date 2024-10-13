//масив - съвкупност от еднотипни елементи

//създаване на празен целочислен масив
int[] integerArray = new int[10];

//създаване на празен дробен масив
double[] doubleArray = new double[5];

//създаване на празен текстов масив
string[] stringArray = new string[3];

//създаване на празен символен масив
char[] charArray = new char[20];

//задаваме стойност на елемент в масив
integerArray[0] = 9;
integerArray[1] = 34;
integerArray[2] = 56;
integerArray[8] = 53;
integerArray[4] = 65;
doubleArray[0] = 5.60;
stringArray[0] = "table";

//достъпваме стойност на елемент в масив
Console.WriteLine(integerArray[0]);
double decimalNumber = doubleArray[0];
Console.WriteLine(stringArray[0]);

//дължина на масива = брой на елементи в него
Console.WriteLine(integerArray.Length);
Console.WriteLine(doubleArray.Length);
Console.WriteLine(stringArray.Length);


//обхождане на масив
int[] numbers = new int[5] { 4, 12, 34, 87, 45 };
//[4, 12, 34, 87, 45]
//1 начин - for цикъл през всички позиции
//когато ни трябва да боравим с позицията на елемента в масива
for (int position = 0; position <= numbers.Length - 1; position++)
{
    numbers[position] = 7; //дава възможност за промяна по време на обхождане
    Console.WriteLine(numbers[position]);
}

//2 начин - foreach цикъл
//foreach цикъл - използва се само са структури от данни / колекции
//когато не работим с позицията на елемента, а само с неговата стойност
//numbers = [4, 12, 34, 87, 45]
foreach (int number in numbers)
{
    //read-only -> нямаме възможност да променяме стойностите в масива
    Console.WriteLine(number);
}




