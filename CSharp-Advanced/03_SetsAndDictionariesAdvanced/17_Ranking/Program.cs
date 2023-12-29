namespace _17_Ranking
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> contestPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> user =
                new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> topCandidate = new Dictionary<string, int>();

            ReadDictionary(contestPassword);

            string input;
            while ((input = Console.ReadLine()).ToUpper() != "END OF SUBMISSIONS")
            {
                string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = tokens[0];
                string pass = tokens[1];
                string userName = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestPassword.ContainsKey(contest) && contestPassword[contest] == pass)
                {
                    if (user.ContainsKey(userName) == false)
                    {
                        user.Add(userName, new Dictionary<string, int>());
                        user[userName].Add(contest, points);
                        topCandidate.Add(userName, +points);
                    }
                    else
                    {
                        if (user[userName].ContainsKey(contest))
                        {
                            if (points > user[userName][contest])
                            {
                                topCandidate[userName] += (points - user[userName][contest]);
                                user[userName][contest] = points;
                            }
                        }
                        else
                        {
                            user[userName][contest] = points;
                            topCandidate[userName] += points;
                        }
                    }
                }
            }

            foreach (var kvp in topCandidate.OrderByDescending(c => c.Value).Take(1))
            {
                Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
            }

            Console.WriteLine("Ranking: ");
            foreach (var kvp in user.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var contest in kvp.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
        public static string ReadDictionary(Dictionary<string, string> contestPassword)
        {
            string input;
            while ((input = Console.ReadLine()).ToUpper() != "END OF CONTESTS")
            {
                string[] tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contest = tokens[0];
                string pass = tokens[1];

                contestPassword.Add(contest, pass);
            }

            return input;
        }
    }
}
