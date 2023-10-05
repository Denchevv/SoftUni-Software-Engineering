string fruit = Console.ReadLine();
string day =  Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());


double total = 0;

if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday)")
{
    switch (fruit)
    {
        case "banana":
            total = 2.5 * quantity;
           break;
        case "apple":
            total = 1.2 * quantity;
            break;
        case "orange":
            total = 0.85 * quantity;
            break;
        case "grapefruit":
            total = 1.45 * quantity;
            break;
        case "kiwi":
            total = 2.7 * quantity;
            break;
        case "pineapple":
            total = 5.5 * quantity;
            break;
        case "grapes":
            total = 3.85 * quantity;
            break;
        default:
            Console.WriteLine("error");
            break;
    }

}
else if (day == "Saturday" || day == "Sunday")
{
    switch (fruit)
    {
        case "banana":
            total = 2.7 * quantity;
            break;
        case "apple":
            total = 1.25 * quantity;
            break;
        case "orange":
            total = 0.9 * quantity;
            break;
        case "grapefruit":
            total = 1.6 * quantity;
            break;
        case "kiwi":
            total = 3 * quantity;
            break;
        case "pineapple":
            total = 5.6 * quantity;
            break;
        case "grapes":
            total = 4.2 * quantity;
            break;
        default:
            Console.WriteLine("error");
            break;
    }
}
else
{
    Console.WriteLine("error");
}

if(total > 0)
{
    Console.WriteLine($"{total:F2}");
}
