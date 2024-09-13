int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int boardCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pensPrice = pens * 5.80;
double markersPrice = markers * 7.20;
double boardCleanerPrice = boardCleaner * 1.20;

double priceForMaterials = pensPrice + markersPrice + boardCleanerPrice;
double materialsDiscount = (priceForMaterials * discount) / 100;

double total = priceForMaterials - materialsDiscount;

Console.WriteLine(total);