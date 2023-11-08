using System;

namespace _05_TeamworkProjects
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
            int teamsForReg = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsForReg; i++)
            {
                string[] data = Console.ReadLine().Split('-');

                string creatorName = data[0];
                string teamName = data[1];

                bool doesTeamExist = teams.Any(x => x.TeamName == teamName);
                bool doesCreatorNameExist = teams.Any(x => x.CreatorName == creatorName);

                if (doesCreatorNameExist == false && doesTeamExist == false)
                {
                    Team team = new Team(teamName, creatorName);

                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (doesTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (doesCreatorNameExist == false)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");

                }
            }

            while (true)
            {
                string data2 = Console.ReadLine();
                if (data2 == "end of assignment")
                {
                    break;
                }
                string[] dataArray = data2.Split("->");

                string memberName = dataArray[0];
                string teamName = dataArray[1];

                bool doesTeamExist = teams.Any(x => x.TeamName == teamName);
                bool isItAlreadyAMember = teams.Any(x => x.Members.Contains(memberName) ||
                                           x.CreatorName == memberName);

                if (doesTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (isItAlreadyAMember == true)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                if (doesTeamExist && isItAlreadyAMember == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.TeamName == teamName);
                    teams[indexOfTeam].Members.Add(memberName);
                }
            }

            List<Team> teamsWithMembers = teams.Where(x => x.Members.Count > 0)
                                          .OrderByDescending(x => x.Members)
                                          .ThenBy(x => x.TeamName)
                                          .ToList();
            List<Team> teamWithoutMembers = teams.Where(x => x.Members.Count == 0)
                                            .OrderBy(x => x.TeamName)
                                            .ToList();

            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"-{team.CreatorName}");
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x=>$"--{x}")));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamWithoutMembers)
            {
                Console.WriteLine(team.TeamName);
            }


        }
    }
}
