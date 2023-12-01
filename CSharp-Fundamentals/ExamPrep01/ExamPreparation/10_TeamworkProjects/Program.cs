namespace _10_TeamworkProjects
{
    class TeamProject
    {
        public TeamProject(string creatorName, string teamName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<TeamProject> list = new List<TeamProject>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creatorName = input[0];
                string teamName = input[1];

                bool doesTeamExists = list.Any(x => x.TeamName == teamName);
                bool isItCreator = list.Any(x => x.CreatorName == creatorName);

                if (doesTeamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (isItCreator)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                TeamProject teamProject = new TeamProject(creatorName, teamName);
                list.Add(teamProject);

                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of assignment")
                {
                    break;
                }

                string[] input = line.Split(new[] {"-", ">"}, StringSplitOptions.RemoveEmptyEntries);

                string member = input[0];
                string teamName = input[1];

                bool teamExists = list.Any(x => x.TeamName == teamName);
                bool isItMember = list.Any(x => x.Members.Contains(member)
                               || list.Any(x => x.CreatorName == member));


                if (teamExists == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (isItMember)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                int indexOfTeam = list.FindIndex(x => x.TeamName == teamName);
                list[indexOfTeam].Members.Add(member);
            }

            List<TeamProject> disbandTeams = list.Where(x => x.Members.Count == 0)
                                            .OrderBy(x => x.TeamName)
                                            .ToList();

            var resultList = list.Where(x => x.Members.Count > 0)
                            .OrderByDescending(x => x.Members.Count)
                            .ThenBy(x => x.TeamName)
                            .ToList();

            foreach (TeamProject kvp in resultList)
            {
                string teamName = kvp.TeamName;
                string creatorName = kvp.CreatorName;

                Console.WriteLine($"{teamName}");
                Console.WriteLine($"- {creatorName}");
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Members.Select(x => $"-- {x}")));
            }
            Console.WriteLine("Teams to disband:");

            foreach (TeamProject team in disbandTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }

    }
}
