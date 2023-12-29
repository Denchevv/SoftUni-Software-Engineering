

namespace _12_EvenTimes
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbersRepetition = new Dictionary<int, int>();

            FillTheDictionary(numbersRepetition, n);
            PrintOutput(numbersRepetition);
        }

        static void PrintOutput(Dictionary<int, int> numbersRepetition)
        {
            foreach (var kvp in numbersRepetition.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(kvp.Key);
            }
        }
        static void FillTheDictionary(Dictionary<int, int> numbersRepetition, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (numbersRepetition.ContainsKey(number))
                {
                    numbersRepetition[number]++;
                }
                else
                {
                    numbersRepetition.Add(number, 1);
                }
            }
        }
    }
}
