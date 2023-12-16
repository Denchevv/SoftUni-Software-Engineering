int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

headsetPrice = lostGamesCount / 2 * headsetPrice;
mousePrice = lostGamesCount / 3 * mousePrice;
keyboardPrice = lostGamesCount / 6 * keyboardPrice;
displayPrice = lostGamesCount / 12 * displayPrice;

Console.WriteLine($"Rage expenses: {headsetPrice + mousePrice + keyboardPrice + displayPrice:f2} lv.");