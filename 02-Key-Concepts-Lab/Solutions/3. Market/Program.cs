//краставици
//домати

//1. входни данни
double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

//2. общата сума на зеленчуци = сума за домати + сума за краставици
double totalSum = (tomatoPrice * tomatoQuantity) 
                + (cucumberPrice * cucumberQuantity);

//3. отпечатване
Console.WriteLine($"{totalSum:F2}");
