namespace _18_SoftUniExamResults
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> users =
                new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }

                string[] tokens = input.Split('-');

                string name = tokens[0];
                string language = tokens[1];
                if (language == "banned")
                {
                    users.Remove(name);
                    continue;
                }

                int points = int.Parse(tokens[2]);

                if (users.ContainsKey(name) == false)
                {
                    users.Add(name, new Dictionary<string, int>());
                    users[name].Add(language, points);

                    if (submissions.ContainsKey(language) == false)
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                else
                {
                    if (users[name].ContainsKey(language))
                    {
                        if (users[name][language] < points)
                        {
                            users[name][language] = points;
                        }
                    }
                    else
                    {
                        users[name].Add(language, points);
                    }
                    submissions[language]++;
                }
            }

            var orderedUsers = users
                .OrderByDescending(u => u.Value.Values.Max())
                .ThenBy(u => u.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results: ");
            foreach (var user in orderedUsers)
            {
                Console.WriteLine($"{user.Key} | {string.Join("",user.Value.Values.Max())}");
            }

            Console.WriteLine($"Submissions: ");
            foreach (var kvp in submissions.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}