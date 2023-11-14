namespace _19_TeamProject3
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; } = new List<string>();
    }
    public class Program
    {
        public static void Main()
        {
            int registrationRange = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < registrationRange; i++)
            {
                string[] input = Console.ReadLine().Split("-");

                string creatorName = input[0];
                string teamName = input[1];

                bool isAlreadyCreator = teams.Any(x => x.CreatorName == creatorName);
                bool teamExists = teams.Any(x => x.TeamName == teamName);

                if (isAlreadyCreator)
                {
                    int indexOfTeam = teams.FindIndex(x => x.CreatorName == creatorName);
                    Console.WriteLine($"{teams[indexOfTeam].CreatorName} cannot create another team!");
                }
                if (teamExists)
                {
                    int indexOfTeam = teams.FindIndex(x => x.TeamName == teamName);
                    Console.WriteLine($"Team {teams[indexOfTeam].TeamName} was already created!");

                }
                if (teamExists == false && isAlreadyCreator == false)
                {
                    Team team = new Team(teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                string[] data = input.Split("->");

                string memberName = data[0];
                string teamName = data[1];

                bool teamExist = teams.Any(x => x.TeamName == teamName);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(memberName) || x.CreatorName == memberName);

                if (teamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (isAlreadyMember)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                if (teamExist && isAlreadyMember == false)
                {
                    int indexOfteam = teams.FindIndex(x => x.TeamName == teamName);
                    teams[indexOfteam].Members.Add(memberName);
                }
            }

            List<Team> teamWithMembers = teams.Where(x => x.Members.Count > 0)
                                         .OrderByDescending(x => x.Members.Count)
                                         .ThenBy(x => x.TeamName)
                                         .ToList();
            List<Team> teamWithoutMembers = teams.Where(x => x.Members.Count == 0)
                                            .OrderBy(x => x.TeamName)
                                            .ToList();

            foreach (Team team in teamWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => $"--{x}")));
            }
            Console.WriteLine("Teams to disband:");
            foreach(Team team in teamWithoutMembers)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}