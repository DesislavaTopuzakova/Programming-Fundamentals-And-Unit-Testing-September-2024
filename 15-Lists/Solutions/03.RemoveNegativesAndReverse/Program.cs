
List<int> numbers = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToList();

for (int i = 0; i < numbers.Count; i++)
{
    int currentElement = numbers[i];

    if (currentElement < 0)
    {
        numbers.Remove(currentElement);
        i--;
    }
}

numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", numbers));
}

