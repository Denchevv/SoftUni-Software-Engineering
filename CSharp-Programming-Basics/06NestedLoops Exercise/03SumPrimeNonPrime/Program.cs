string input = Console.ReadLine();
int primeSum = 0, nonPrimeSum = 0;

while (input != "stop")
{
    int inputNum = int.Parse(input);
    bool isNonPrime = false;
   
    if (inputNum < 0)
    {
        Console.WriteLine("Number is negative.");
    }
    else
    {
        for (int i = 2; i <= inputNum / 2; i++)
        {
            if (inputNum % i == 0)
            { isNonPrime = true; }
        }
        if (isNonPrime && inputNum >= 0) { nonPrimeSum += inputNum; }
        else {  primeSum += inputNum; }
    }

    input = Console.ReadLine();
}
Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");