//split -> текст го преобразуваме в масив от текстове
string sentence = "I am Desislava Topuzakova and I am 26 years old";
string[] words = sentence.Split(" ");
//["I", "am", "Desislava", "Topuzakova", "and", "I", "am", "26", "years", "old"]

//join -> масив от всякакъв вид го преобразуваме в текст
int[] numbers = { 4, 5, 23, 45, 98 };
string result = string.Join(", ", numbers);
Console.WriteLine(result);
Console.WriteLine(string.Join("", numbers));