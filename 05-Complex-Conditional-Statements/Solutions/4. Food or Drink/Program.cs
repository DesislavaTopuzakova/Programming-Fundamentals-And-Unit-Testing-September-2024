//входни данни
string product = Console.ReadLine();

//проверка дали продуктът е храна
if (product == "curry" || product == "noodles" ||
    product == "sushi" || product == "spaghetti" ||
    product == "bread")
{
    Console.WriteLine("food");
}
// проверка дали продуктът е напитка
else if (product == "tea" || product == "water" ||
        product == "coffee" || product == "juice")
{
    Console.WriteLine("drink");
}
//продуктът не е нито един от въведените
else
{
    Console.WriteLine("unknown");
}
