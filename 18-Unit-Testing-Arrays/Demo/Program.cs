// Deep Sorting
int[] ints = new int[] { 3, 2, 1 };

Console.WriteLine(string.Join(", ", ints));

Array.Sort(ints);

Console.WriteLine("After Deep Sorting");
Console.WriteLine(string.Join(", ", ints));

// Shallow Sorting
int[] intsArr = new int[] { 3, 2, 1 };

Console.WriteLine(string.Join(", ", intsArr));

int[] newArray = intsArr.OrderBy(i => i).ToArray();

Console.WriteLine("After Shallow Sorting");
Console.WriteLine(string.Join(", ", intsArr));
Console.WriteLine(string.Join(", ", newArray));




