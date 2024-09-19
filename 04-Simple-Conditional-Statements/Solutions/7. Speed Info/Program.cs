//входни данни
double speed = double.Parse(Console.ReadLine());

//проверка за скоростта
if (speed <= 30)
{
    Console.WriteLine("Slow");
}
else
{
    //противен случай: speed > 30
    Console.WriteLine("Fast");
}