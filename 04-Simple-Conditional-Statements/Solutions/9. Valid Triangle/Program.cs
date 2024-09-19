//входни данни
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

//валиден / съществуващ триъгълник
//1. a < b + c
//2. b < a + c
//3. c < a + b

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");

}