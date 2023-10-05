string city = Console.ReadLine();   
double sales = double.Parse(Console.ReadLine());

double commision = 0;


if (sales >= 0 && sales <= 500)
{
	switch (city)
	{
		case "Sofia": commision = sales * 0.05; break;
		case "Varna": commision = sales * 0.045; break;
		case "Plovdiv": commision = sales * 0.055; break;
		default:
            Console.WriteLine("error");
            break;
	}

}
else if (sales > 500 && sales <= 1000)
{
    switch (city)
    {
        case "Sofia": commision = sales * 0.07; break;
        case "Varna": commision = sales * 0.075; break;
        case "Plovdiv": commision = sales * 0.08; break;
        default:
            Console.WriteLine("error");
            break;
    }

}
else if (sales > 1000 && sales <= 10000)
{
    switch (city)
    {
        case "Sofia": commision = sales * 0.08; break;
        case "Varna": commision = sales * 0.1; break;
        case "Plovdiv": commision = sales * 0.12; break;
        default:
            Console.WriteLine("error");
            break;
    }
}
else if (sales > 10000)
{
    switch (city)
    {
        case "Sofia": commision = sales * 0.12; break;
        case "Varna": commision = sales * 0.13; break;
        case "Plovdiv": commision = sales * 0.145; break;
        default:
            Console.WriteLine("error");
            break;
    }

}
else
{
    Console.WriteLine("error");
}

if (commision > 0)
{
    Console.WriteLine($"{commision:F2}");
}