int number = int.Parse(Console.ReadLine()); //основа
int power = int.Parse(Console.ReadLine());  //степен
PrintPower(number, power);


//--------------------------------------------------
//метод, който отпечатва числото повдигнато на дадената степен
static void PrintPower(int number, int power)
{
    Console.WriteLine(Math.Pow(number, power));
}