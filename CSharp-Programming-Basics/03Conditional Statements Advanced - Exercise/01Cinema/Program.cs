string projection = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());

double salesTotal = 0.0;

switch (projection)
{
	case "Premiere": salesTotal = rows * column * 12.0; break;
	case "Normal": salesTotal = rows * column * 7.50; break;
	case "Discount": salesTotal = rows * column * 5.0; break;
}
Console.WriteLine($"{salesTotal:f2} leva");