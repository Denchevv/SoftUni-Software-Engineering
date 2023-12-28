

namespace _15_TheV_Logger
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();
            Dictionary<string, int[]> userNumFollows = new Dictionary<string, int[]>();

            string input;
            while ((input = Console.ReadLine())?.ToUpper() != "STATISTICS")
            {
                string[] tokens = input.Split();

                string vloggerName = tokens[0];
                string command = tokens[1];

                if (command?.ToUpper() == "JOINED")
                {
                    if (vloggers.ContainsKey(vloggerName) == false)
                    {
                        vloggers.Add(vloggerName, new List<string>());
                        userNumFollows[vloggerName] = new int[2];
                    }
                }
                else if (command?.ToUpper() == "FOLLOWED")
                {
                    string userToFollow = tokens[2];

                    if (IsItValid(vloggers, vloggerName, userToFollow))
                    {
                        vloggers[userToFollow].Add(vloggerName);

                        userNumFollows[vloggerName][1]++;
                        userNumFollows[userToFollow][0]++;
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var orderedUserNumFollows = userNumFollows
                .OrderByDescending(u => u.Value[0])
                .ThenBy(u => u.Value[1])
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;
            string userToRemove = string.Empty;

            foreach (var kvp in orderedUserNumFollows)
            {
                userToRemove = kvp.Key;
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;

                if (vloggers[kvp.Key].Count > 0)
                {
                    foreach(string follower in vloggers[kvp.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"* {follower}");
                    }
                }
                break;
            }

            orderedUserNumFollows.Remove(userToRemove);
            foreach (KeyValuePair<string, int[]> kvp in orderedUserNumFollows)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;
            }



        }
    private static bool IsItValid(Dictionary<string, List<string>> vloggers,
        string vloggerName, string vloggerFollowed)
    {
        return (vloggers.ContainsKey(vloggerName)
              && vloggers.ContainsKey(vloggerFollowed)
              && vloggerFollowed != vloggerName
              && vloggers[vloggerFollowed].Contains(vloggerName) == false);

    }
}
}
