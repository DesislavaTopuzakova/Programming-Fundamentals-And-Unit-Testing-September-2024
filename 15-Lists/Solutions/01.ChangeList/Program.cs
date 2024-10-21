
List<int> numbers = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToList();

List<string> cmdArg = Console.ReadLine().Split().ToList();

while (cmdArg[0] != "end")
{
    string command = cmdArg[0];
    if (command == "Delete")
    {
        int elementToDelete = int.Parse(cmdArg[1]);

        //for (int i = 0; i < numbers.Count; i++)       -> вариант с for цикъл 
        //    numbers.Remove(elementToDelete);

        //numbers.RemoveAll(e => e == elementToDelete); -> по-кратък вариант

        while (numbers.Contains(elementToDelete))      // вариант с while цикъл
        {
            numbers.Remove(elementToDelete);
        }
    }
    else if (command == "Insert")
    {
        int elementToInsert = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);

        numbers.Insert(index, elementToInsert);
    }

    cmdArg = Console.ReadLine().Split().ToList();
}

Console.WriteLine(string.Join(" ", numbers));
