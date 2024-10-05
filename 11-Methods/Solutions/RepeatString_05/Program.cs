string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatString(text, count));

//---------------------------------------------------
//метод, който конструира текст и след това го връща
static string RepeatString(string text, int count)
{
    //text = "Ivan"
    //count = 5
    //result = ""
    string result = "";
    for (int i = 1; i <= count; i++)
    {
        result += text;
    }

    //result = "IvanIvanIvanIvanIvan"
    return result;
    
}

