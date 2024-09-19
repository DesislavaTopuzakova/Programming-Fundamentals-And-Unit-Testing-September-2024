//входни данни
int temperature = int.Parse(Console.ReadLine());

//проверка на въведената температура
if (temperature > 100)
{
    Console.WriteLine("The water is boiling");
}
else
{
    //противния случай: temperature <= 100
    Console.WriteLine("The water is not hot enough");
}
