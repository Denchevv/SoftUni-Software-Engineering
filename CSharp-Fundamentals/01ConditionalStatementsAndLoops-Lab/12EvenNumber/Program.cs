int numbers = int.Parse(Console.ReadLine());

while (numbers % 2 != 0)
{
    Console.WriteLine("Please write an even number.");
    numbers = int.Parse(Console.ReadLine());
}
Console.WriteLine($"The number is: {Math.Abs(numbers)}");