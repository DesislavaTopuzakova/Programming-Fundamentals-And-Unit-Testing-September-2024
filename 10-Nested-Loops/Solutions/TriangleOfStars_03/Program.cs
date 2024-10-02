int size = int.Parse(Console.ReadLine());

//за всеки ред от 1 до size

for (int row = 1; row <= size; row++)
{
    //повтаряме: отпечатваме  определен брой *
    //започваме от първата * и приключваме в последната (номер на реда)
    for (int count = 1; count <= row; count++)
    {
        Console.Write("*");
    }
    Console.WriteLine(); //свали курсора на нов ред, за да може следващия ред да се отпечата отдолу
}

