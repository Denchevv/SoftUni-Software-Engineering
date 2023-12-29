namespace _16_The_V_logger2
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vlog =
                new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input;
            while((input = Console.ReadLine()).ToUpper() != "STATISTICS") 
            {
                string[] tokens = input.Split();

                string vloggerName = tokens[0];
                string command = tokens[1];

                if(command.ToUpper() == "JOINED")
                {
                    if(vlog.ContainsKey(vloggerName) == false)
                    {
                        vlog.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        vlog[vloggerName].Add("followers", new HashSet<string>());
                        vlog[vloggerName].Add("following", new HashSet<string>());
                    }
                }
                else if(command.ToUpper() == "FOLLOWED")
                {
                    string userToFollow = tokens[2];
                    if(vlog.ContainsKey(vloggerName) && vlog.ContainsKey(userToFollow) && vloggerName != userToFollow)
                    {
                        vlog[vloggerName]["following"].Add(userToFollow);
                        vlog[userToFollow]["followers"].Add(vloggerName);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vlog.Count} vloggers in its logs.");

            int counter = 1;

            foreach(var vlogger in vlog
                .OrderByDescending(v => v.Value["followers"].Count)
                .ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, " +
                    $"{vlogger.Value["following"].Count} following");

                if(counter == 1)
                {
                    foreach(var followers in vlogger.Value["followers"].OrderBy(f=>f))
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }

                counter++;
            }
        }
    }
}
