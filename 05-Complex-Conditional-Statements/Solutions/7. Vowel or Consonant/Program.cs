//входни данни
char letter = char.Parse(Console.ReadLine());

//проверка дали буквата е гласна
//гласни букви: A, a, E, e, I, i, O, o, U, u

//серия от проверки за точна стойност на една променлива
switch (letter)
{
    case 'A':
    case 'a':
    case 'E':
    case 'e':
    case 'I':
    case 'i':
    case 'U':
    case 'u':
    case 'O':
    case 'o':
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Consonant");
        break;
}