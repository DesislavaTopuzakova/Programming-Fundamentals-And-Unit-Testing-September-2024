// Създаваме лист с int числа
List<int> firstList = new List<int> { 1, 2, 3 };

// Създаваме втори лист, който присвоява елементите от първия лист
List<int> secondList = firstList;

// При отпечатването се уверяваме, че те имат едни и същи елементи
Console.WriteLine(string.Join(", ", firstList));   // 1, 2, 3
Console.WriteLine(string.Join(", ", secondList));  // 1, 2, 3

// Добавяме числото 4 само във втория лист
secondList.Add(4); 

// При отпечатването на елементите на двата листа виждаме, 
// че числото 4 присъства вече и в първия лист
Console.WriteLine(string.Join(", ", firstList)); // 1, 2, 3, 4
Console.WriteLine(string.Join(", ", secondList)); // 1, 2, 3, 4

// Това се получава защото типа List е референтен тип и когато кажем, 
// че един List = друг List, двата листа сочат към една и съща референция
// в RAM паметта на компютъра


