namespace _02GaussTrick
{
    internal class Program
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++) 
            {
                int firstNumber = numbers[i];
                int secondNumber = numbers[numbers.Count - 1 - i];

                int sum = firstNumber + secondNumber;
                result.Add(sum);

            }

            if (numbers.Count % 2 == 1)
            {
                int middleNum = numbers[numbers.Count / 2];
                result.Add(middleNum);
            }
            Console.WriteLine(string.Join(" ", result));
        }   

    }
}