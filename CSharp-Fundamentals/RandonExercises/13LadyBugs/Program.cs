namespace _13LadyBugs
{
    public class Program
    {
        public static void Main()
        {

            int fieldSize = int.Parse(Console.ReadLine());
            int[] fieldArray = new int[fieldSize];

            int[] bugsIndexes = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            for (int i = 0; i < bugsIndexes.Length; i++)
            {
                int index = bugsIndexes[i];
                fieldArray[index] = 1;
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] token = line.Split();

                int bugIndex = int.Parse(token[0]);
                string direction = token[1];
                int indexToMoveWith = int.Parse(token[2]);

                if (direction == "right")
                {


                }
                else
                {

                }
            }
            Console.WriteLine(string.Join(" ", fieldArray));

        }
    }
}