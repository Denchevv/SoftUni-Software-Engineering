namespace _05CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] originalArray = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();


            while (originalArray.Length > 1)
            {
                int[] condensedArray = new int[originalArray.Length - 1];

                for (int i = 0; i < condensedArray.Length; i++)
                {
                    condensedArray[i] = originalArray[i] + originalArray[i + 1];
                }

                originalArray = condensedArray;

            }
            Console.WriteLine(originalArray[0]);
        }
    }
}