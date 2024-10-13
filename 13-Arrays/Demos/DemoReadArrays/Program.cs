//четем целочислен масив от конзолата
int[] numbers = Console.ReadLine() //"5 3 6 3 4"
                .Split(" ")        // ["5", "3", "6", "3", "4"]
                .Select(int.Parse) //[5, 3, 6, 3, 4]
                .ToArray();

//четем дробен масив от конзолата
double[] decimalNumbers = Console.ReadLine() //"3.4 7.8 9.5 3.1"
                          .Split(" ")        //["3.4", "7.8", "9.5", "3.1"]
                          .Select(double.Parse) //[3.4, 7.8, 9.5, 3.1]
                          .ToArray();

//четем текстов масив от конзолата
string[] names = Console.ReadLine() //"Desi Yasen Vasil"
                 .Split(" ");       //["Desi", "Yase", "Vasil"]


//четем символен масив от конзолата
char[] symbols = Console.ReadLine() //"U R T S J W"
                 .Split(" ")        //["U", "R", "T", "S", "J", "W"]
                 .Select(char.Parse)//['U', 'R', 'T', 'S', 'J', 'W']
                 .ToArray();