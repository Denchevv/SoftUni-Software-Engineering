int n1 = int.Parse(Console.ReadLine()); 
int n2 = int.Parse(Console.ReadLine());
string symbol =  Console.ReadLine();

double result = 0;

if (symbol == "+") { result = n1 + n2; }
else if (symbol == "-") { result = n1 - n2; }

else if (symbol == "*") { result = n1 * n2; }

else if (symbol == "/" && n2 != 0) { result = (double) n1 / n2; }

else if (symbol == "%" && n2 != 0) { result = n1 % n2; }


string evenOrOdd = "";
if (result % 2 == 0)
{
    evenOrOdd = "even";
} else
{
    evenOrOdd = "odd";
}


if (n2 != 0)
{
    if (symbol == "+" || symbol == "-" || symbol == "*")
    {
        Console.WriteLine($"{n1} {symbol} {n2} = {result} - {evenOrOdd}");
    }
    else if (symbol == "/")
    {
        Console.WriteLine($"{n1} {symbol} {n2} = {result:f2}");
    }
    else if (symbol == "%")
    {
        Console.WriteLine($"{n1} {symbol} {n2} = {result}");
    }
}
else
{
     Console.WriteLine($"Cannot divide {n1} by zero"); 
}