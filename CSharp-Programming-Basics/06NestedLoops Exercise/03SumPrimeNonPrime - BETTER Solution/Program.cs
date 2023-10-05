string input = Console.ReadLine();
int primeSum = 0, nonPrimeSum = 0;

while (input != "stop")
{
    int inputNum = int.Parse(input);

    if (inputNum < 0)
    {
        Console.WriteLine("Number is negative.");
    }
    else
    {
        bool isPrime = true;
        double sqrt = Math.Sqrt(inputNum);
        for (int i = 2; i <= sqrt; i++) 
        {
            if (inputNum % i == 0) 
            {
                isPrime = false;
                break;  
            }
        }
        if (isPrime) { primeSum += inputNum; }
        else { nonPrimeSum += inputNum; }
    }

    input = Console.ReadLine();
}
Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");