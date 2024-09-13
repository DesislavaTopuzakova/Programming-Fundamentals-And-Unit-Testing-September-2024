int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int totalReadingTime = pages / pagesPerHour;
int hoursNeeded = totalReadingTime / days;

Console.WriteLine(hoursNeeded);