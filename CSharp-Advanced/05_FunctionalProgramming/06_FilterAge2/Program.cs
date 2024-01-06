namespace _06_FilterAge2
{
    public class Program
    {
        public static void Main()
        {
            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;

            int n = int.Parse(Console.ReadLine());
            List<(string, int)> people = new List<(string, int)>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people.Add((person[0], int.Parse(person[1])));
            }

            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string[] filterFormat = Console.ReadLine().Split();

            switch (condition)
            {
                case "younger":
                    people = people
                        .Where(p => younger(p, ageFilter))
                        .ToList();
                    break;
                case "older":
                    people = people
                        .Where(p => older(p, ageFilter))
                        .ToList();
                    break;
            }


            foreach (var p in people)
            {
                List<string> resultList = new List<string>();

                if (filterFormat.Contains("name"))
                {
                    resultList.Add(p.Item1);
                }

                if (filterFormat.Contains("age"))
                {
                    resultList.Add(p.Item2.ToString());
                }

                if (filterFormat.Length == 2)
                {
                    Console.Write(string.Join(" - ", resultList));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(string.Join(" ", resultList));
                }

            }
        }
    }
}