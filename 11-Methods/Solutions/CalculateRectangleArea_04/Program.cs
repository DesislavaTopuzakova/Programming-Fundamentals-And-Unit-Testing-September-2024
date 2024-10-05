int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

PrintRectangleArea(width, length);

//-----------------------------------------
//метод, който отпечатва лице на правоъгълник
static void PrintRectangleArea(int width, int length)
{
    //лице на правоъгълник = width * length
    int area = width * length;
    Console.WriteLine(area);
}