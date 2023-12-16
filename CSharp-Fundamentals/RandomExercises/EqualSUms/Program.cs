namespace EqualSUms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int rightSum = 0;
            int leftSum = 0;


            foreach (int number in numbers)
            {
                rightSum += number;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum -= numbers[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += numbers[i];
            }
            Console.WriteLine("no");;
        }
    }
}
