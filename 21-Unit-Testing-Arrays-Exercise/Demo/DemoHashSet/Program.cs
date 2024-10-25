// В лист няма проблем да има повтарящи се елементи
List<string> sports = new List<string>();
sports.Add("Tennis");
sports.Add("Football");
sports.Add("Volleyball");
sports.Add("Swimming");
sports.Add("Tennis");
sports.Add("Tennis");

Console.WriteLine("List count and elements");
Console.WriteLine(sports.Count); // 6
Console.WriteLine(string.Join(", ", sports));

// HashSet пази само уникални елементи
Console.WriteLine("----------------------");
HashSet<string> strings = new HashSet<string>();
strings.Add("Tennis");
strings.Add("Football");
strings.Add("Volleyball");
strings.Add("Swimming");
strings.Add("Tennis");
strings.Add("Tennis");

Console.WriteLine("HashSet count and elements");
Console.WriteLine(strings.Count);  //4
Console.WriteLine(string.Join(", ", strings));

