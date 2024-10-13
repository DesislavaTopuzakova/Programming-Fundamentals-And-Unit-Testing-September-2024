int number = int.Parse(Console.ReadLine()); //номер на деня

string[] daysOfWeek = new string[7] {
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

//проверка за въведеното число
if (number >= 1 && number <= 7)
{
    Console.WriteLine(daysOfWeek[number - 1]);
}
else
{
    //number да не е в диапазона от 1 до 7
    Console.WriteLine("Invalid day!");
}

