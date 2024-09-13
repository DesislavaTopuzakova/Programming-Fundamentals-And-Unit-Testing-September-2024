// 1. входни данни
double depositAmount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double annualRate = double.Parse(Console.ReadLine()) / 100; //5.7% / 100 = 0.057

// 2. изчисляваме сумата след депозита
double finalSum = depositAmount + months * (depositAmount * annualRate) / 12;

// 3. отпечатваме сумата след депозита
Console.WriteLine($"{finalSum:F2}");
