//закръгляне / rounding

double number = 5.17892424;

//закръгляне към най-близкото цяло число
Console.WriteLine(Math.Round(number));

//закръгляне към най-близкото по-малко цяло число
Console.WriteLine(Math.Floor(number));

//закръгляне към най-близкото по-голямо цяло число
Console.WriteLine(Math.Ceiling(number));

//закръгляне до даденa цифра след десетичната запетая
Console.WriteLine(Math.Round(number, 2));

//форматиране vs закръгляне
double price = 4.50324234;

//форматиране -> закръгляне до съответната цифра + подсигурява, че ще се отпечатат точния брой цифри
Console.WriteLine($"{price:F2}");
//закгръляне -> закръгляне до съответната цифра + отреже излишните нули
Console.WriteLine(Math.Round(price, 2)); 

