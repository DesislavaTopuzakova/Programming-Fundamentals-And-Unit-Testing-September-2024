
List<string> names = new List<string>() { "Pesho", "Mitko" };

names.Add("Gosho");
names.Add("Dimitrichko");
names.Add("Mimi");
names.Add("Angel");

names.Sort();
names.Reverse();

foreach (var name in names)
    Console.WriteLine(name);

//Console.WriteLine(names[0]);

List<int> nums = new List<int>() { 10, 20, 30, 40, 50, 60 };

nums.Remove(30);
// 10, 20, 40, 50, 60

nums.Add(100);
// 10, 20, 40, 50, 60, 100

nums.Insert(0, -100);
// -100, 10, 20, 40, 50, 60, 100

Console.WriteLine(string.Join(", ", nums));
Console.WriteLine($"Count: {nums.Count}");

int n = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>();

for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    numbers.Add(currentNum);
}

Console.WriteLine(string.Join(", ", numbers));

// печатане на лист в конзолата

List<string> numbersInWords = new List<string>() { "one", "two", "three", "four", "five"};

for (int i = 0; i < numbersInWords.Count; i++)
{
    Console.WriteLine($"list[{i}] = {numbersInWords[i]}");
}

// печатане на нов ред със string.Join
Console.WriteLine(string.Join(Environment.NewLine, numbersInWords));

// печатане на нов ред с foreach цикъл
foreach (var number in numbersInWords)
    Console.WriteLine(number);


// сортиране на лист в обратен ред с помощта на методите Sort и Reverse

List<int> ints = new List<int>() { 50, 20, 60, 40, 10, 30 };

ints.Sort();
ints.Reverse();

foreach (int num in ints)
    Console.WriteLine(num);








