
// 1.While loop and collection of the coins
string input = Console.ReadLine();

double collectedMoney = 0;

while (input != "Start")
{
    double currentMoney = double.Parse(input);
    if (currentMoney == 2) { collectedMoney += currentMoney; }
    else if (currentMoney == 1) {  collectedMoney += currentMoney; }
    else if (currentMoney == 0.5) {  collectedMoney += currentMoney; }
    else if (currentMoney == 0.2) {  collectedMoney += currentMoney; }
    else if (currentMoney == 0.1) {  collectedMoney += currentMoney; }
    else { Console.WriteLine($"Cannot accept {currentMoney}"); }

    input = Console.ReadLine();
}

//2. Second Loop and purchasing of the items

bool notEnoughMoney = false;
string product = Console.ReadLine();
while (product != "End") 
{
    if(product == "Nuts")
    {
        if (collectedMoney >= 2)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            collectedMoney -= 2;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Water" ) 
    {
        if (collectedMoney >= 0.7)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            collectedMoney -= 0.7;
        }else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Crisps") 
    {
        if (collectedMoney >= 1.5)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            collectedMoney -= 1.5;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Soda")  
    {
        if (collectedMoney >= 0.8)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            collectedMoney -= 0.8;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Coke") 
    {
        if (collectedMoney >= 1.0)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            collectedMoney -= 1.0;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }



    product = Console.ReadLine();
}

//3. Print output
Console.WriteLine($"Change: {collectedMoney:f2}");