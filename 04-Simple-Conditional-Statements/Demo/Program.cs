//булева променлива се съхранява булев тип данни (true / false)
//булев тип данни: true / false
bool isValid = false;
bool isCorrect = true;

//аритметични оператори: +, -, *, /, %
//оператор за задаване на стойност: =
//оператори  сравнение: ==, !=, >, >=, <, <=

//булев израз: има оператор за сравнение -> стойността е true / false
bool isLower = 5 < 6;
Console.WriteLine(isLower);

//Живот на променливата
//създаваме променлива: тип, име, стойност
int number = 6;

if (isCorrect)
{
    string name = "Desi";
    {
        Console.WriteLine(name);
    }
    Console.WriteLine(number);
}

//Console.WriteLine(name); -> error

//тернарен оператор -> if-else конструкция описана на един ред
Console.WriteLine(number > 5 ? "Yes" : "No");