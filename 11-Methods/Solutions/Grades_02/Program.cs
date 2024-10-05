double grade = double.Parse(Console.ReadLine());

PrintGradeAsText(grade);


//----------------------------------------------
//метод, който да отпечатва оценката като текст
//1. static
//2. вид на метода
//3. име на метода
//4. параметри в ()
static void PrintGradeAsText(double grade)
{
    if (grade >= 2.00 && grade <= 2.99)
    {
        Console.WriteLine("Fail");
    }
    else if (grade >= 3.00 && grade <= 3.49)
    {
        Console.WriteLine("Average");
    }
    else if (grade >= 3.50 && grade <= 4.49)
    {
        Console.WriteLine("Good");
    }
    else if (grade >= 4.50 && grade <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    else if (grade >= 5.50 && grade <= 6.00)
    {
        Console.WriteLine("Excellent");
    }
}