int floors = int.Parse(Console.ReadLine());
int estates = int.Parse(Console.ReadLine());

//всеки етаж от последния до първия
for (int floor = floors; floor >= 1; floor--)
{
    //всеки един недвижим имот
    for (int estate = 0; estate < estates; estate++)
    {
        //проверка на кой етаж се намирам -> последен етаж, четен етаж, нечетен етаж
        if (floor == floors)
        {
            //estate е голям апартамент (L)
            Console.Write($"L{floor}{estate} ");
        }
        else if (floor % 2 == 0)
        {
            //estate е офис (O)
            Console.Write($"O{floor}{estate} ");
        }
        else
        {
            //estate е апартамент (A)
            Console.Write($"A{floor}{estate} ");
        }
    }

    Console.WriteLine(); //свали курсора на нов ред
}
