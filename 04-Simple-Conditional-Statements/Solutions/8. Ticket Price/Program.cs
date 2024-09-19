//входни данни
string ticketType = Console.ReadLine();

//проверка за вида на билета: "student", "regular"
if (ticketType == "student")
{
    //студентски билет
    Console.WriteLine("$1.00");
}
else if (ticketType == "regular")
{
    //редовен билет
    Console.WriteLine("$1.60");
}
else
{
    //ако нито едно от горните не е изпълнено
    Console.WriteLine("Invalid ticket type!");
}
