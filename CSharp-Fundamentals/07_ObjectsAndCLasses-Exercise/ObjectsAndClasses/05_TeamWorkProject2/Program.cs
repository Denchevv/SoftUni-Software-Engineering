using System.Diagnostics.Metrics;

namespace _05_TeamWorkProject2
{
    class Team
    {
        public Team(string teamName, string creatorName)
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
            int numberOfProjects = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfProjects; i++)
            {
                string[] data = Console.ReadLine()
                                .Split('-');

                string creatorName = data[0];
                string teamName = data[1];

                bool teamAlreadyExists = teams.Any(x => x.TeamName == teamName);
                bool alreadyCreated = teams.Any(x => x.CreatorName == creatorName);

                if (teamAlreadyExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                if (alreadyCreated)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                if (teamAlreadyExists == false && alreadyCreated == false)
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
                string[] data2 = input.Split("->");
                string memberName = data2[0];
                string teamName = data2[1];

                bool doesTeamExist = teams.Any(x => x.TeamName == teamName);
                bool alreadyMember = teams.Any(x => x.Members.Contains(memberName) ||
                                               x.CreatorName == memberName);

                if (doesTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (alreadyMember)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                if (doesTeamExist && alreadyMember == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.TeamName == teamName);
                    teams[indexOfTeam].Members.Add(memberName);
                }
            }

            List<Team> approvedTeams = teams.Where(x => x.Members.Count > 0)
                                        .OrderByDescending(x => x.Members.Count)
                                        .ThenBy(x => x.TeamName)
                                        .ToList();
            List<Team> dispandTeams = teams.Where(x => x.Members.Count <= 0)
                                      .OrderBy(x => x.TeamName)
                                      .ToList();

            foreach (Team team in approvedTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => $"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in dispandTeams)
            {
                Console.WriteLine(team.TeamName);
            }

        }
    }
}