namespace _05_FilterByAge
{
    public class Program
    {
        public static void Main()
        {
            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;

            int n = int.Parse(Console.ReadLine());
            List<(string name, int age)> people = new List<(string name, int age)>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = person[0];
                int age = int.Parse(person[1]);

                people.Add((name, age));
            }

            string experience = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string[] filter = Console.ReadLine().Split();

            switch (experience)
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


            foreach (var person in people)
            {
                List<string> result = new List<string>();

                if (filter.Contains("name"))
                {
                    result.Add(person.name);
                }

                if (filter.Contains("age"))
                {
                    result.Add(person.age.ToString());
                }

                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
