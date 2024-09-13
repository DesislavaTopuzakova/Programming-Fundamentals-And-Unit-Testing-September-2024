// 1. входни данни
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());


//2. изпълняваме аритметичните операции
// събиране
double sum = firstNumber + secondNumber;

// изваждане
double diff = firstNumber - secondNumber;

//умножение
double product = firstNumber * secondNumber;

//деление
double division = firstNumber / secondNumber;

//3. отпечатваме
Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sum:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {diff:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {product:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {division:F2}");