//1. входни данни
double bathWidth = double.Parse(Console.ReadLine());
double bathHeigth = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeigth = double.Parse(Console.ReadLine());

//2. намираме площта на стената в банята
double bathArea = bathWidth * bathHeigth; //създаваме променливата и задаваме стойност

//3. добавяме 10% = 0.1 повече за покриване
bathArea = bathArea + 0.10 * bathArea;
//bathArea = 1.10 * bathArea;
//променяме стойността на вече съществуващата променлива

//4. намираме площта на една плочка
double tileArea = tileWidth * tileHeigth;

//5. изчислявам нужните плочки
double countTiles = bathArea / tileArea;

//6. отпечатваме
Console.WriteLine(Math.Round(countTiles));

