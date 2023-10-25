namespace _01EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();

            }

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                string currentName = names[i];
                int length = currentName.Length;
                int numResult = 0;

                for (int j = 0; j < currentName.Length; j++)
                {
                    char letter = currentName[j];


                    if ("aeiou".Contains(letter) || "AEIOU".Contains(letter))
                    {
                        numResult += (int)letter * length;

                    }
                    else
                    {
                        numResult += (int)letter / length;

                    }
                }
                result[i] += numResult;

            }
            Array.Sort(result);
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
