//1. входни данни
double usd = double.Parse(Console.ReadLine());

//2. изчислението в евро = долари * 0.88
double euro = usd * 0.88;

//3. отпечатваме
Console.WriteLine($"{euro:F2}");

