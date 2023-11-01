namespace _03_HouseParty
{
    internal class Program
    {
        static void Main()
        {
           int commandsNumber = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < commandsNumber; i++)
            {
               
                string[] token = Console.ReadLine().Split();
                string name = token[0];
                string command = token[2];

                if(command != "not")
                {
                    if(names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }else
                    {
                        names.Add(name);
                    }
                }
                else
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);

                    }else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}