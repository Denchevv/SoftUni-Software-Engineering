namespace _10_SetsOfElements
{
    public class Program
    {
        public static void Main()
        {
            int[] setsLength = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> numbersN = new HashSet<int>();
            HashSet<int> numbersM = new HashSet<int>();

            int range = setsLength[0] + setsLength[1];

            for (int i = 0; i < range; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (i < setsLength[0])
                {
                    numbersN.Add(inputNumber);
                }
                else
                {
                    numbersM.Add(inputNumber);
                }
            }

            foreach (int number in numbersN)
            {
                if (numbersM.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }

        }
    }
}
