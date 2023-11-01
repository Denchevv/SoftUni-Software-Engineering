namespace _02_AddList
{
    internal class Program
    {
        public static void Main()
        {
            List<int> numbersList = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] token = line.Split();

                string command = token[0];
                int number = int.Parse(token[1]);

                switch (command)
                {
                    case "Delete":

                        numbersList.RemoveAll(x => x == number);
                        break;
                    case "Insert":
                        int index = int.Parse(token[2]);
                        numbersList.Insert(index,number);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }

    }
}