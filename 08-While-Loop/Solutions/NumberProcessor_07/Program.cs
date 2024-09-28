int number = int.Parse(Console.ReadLine());
string command = Console.ReadLine();


while (command != "End")
{

    if (command == "Inc")
    {
        number += 1;
        command = Console.ReadLine();
    }
    else if (command == "Dec")
    {
        number -= 1;
        command = Console.ReadLine();
    }

}

Console.WriteLine(number);