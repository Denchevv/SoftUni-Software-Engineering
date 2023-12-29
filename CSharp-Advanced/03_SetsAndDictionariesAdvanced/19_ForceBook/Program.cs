namespace _19_ForceBook
{
    internal class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> sideClub = new Dictionary<string, List<string>>();
            Dictionary<string, string> users = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    string[] tokens = input.Split(" | ");
                    string side = tokens[0];
                    string user = tokens[1];

                    if (users.ContainsValue(user) == false && sideClub.ContainsKey(side) == false)
                    {
                        sideClub.Add(side, new List<string> { user });
                        users.Add(user, side);
                    }
                   
                }
                else if (input.Contains("->"))
                {
                    string[] tokens = input.Split(" -> ");

                    string user = tokens[0];
                    string side = tokens[1];
                    bool isTheSame = false;
                    if (users.ContainsKey(user) && sideClub.ContainsKey(side)) // User and side exist
                    {
                        if (side == users[user])
                        {
                           isTheSame = true;
                        }
                        string sideToRemoveFrom = users[user];      // Find the user`s previous side
                        sideClub[sideToRemoveFrom].Remove(user);    // Remove the user from the old side
                        sideClub[side].Add(user);                   // Add the user to the new side
                        users[user] = side;                         // Update the users side 
                    }
                    else if (users.ContainsKey(user) && sideClub.ContainsKey(side) == false) // User exists, Side - not
                    {
                        string sideToRemoveFrom = users[user];      // Find the user`s previous side
                        sideClub[sideToRemoveFrom].Remove(user);    // Remove the user from the old side
                        sideClub.Add(side, new List<string> { user }); // Initialize the new side and the list
                        users[user] = side;                         // Update the users side 
                    }
                    else if (users.ContainsKey(user) == false && sideClub.ContainsKey(side)) //User not, Side exists
                    {
                        sideClub[side].Add(user);
                        users.Add(user, side);
                    }
                    else if (users.ContainsKey(user) == false && sideClub.ContainsKey(side) == false) // NOT EXIST BOTH
                    {
                        sideClub.Add(side, new List<string> { user });
                        users.Add(user, side);
                    }

                    if(isTheSame == false)
                    {
                    Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }

            foreach (var kvp in sideClub.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
            {
                if (kvp.Value.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                foreach (var kvp2 in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {kvp2}");
                }
            }
        }
    }
}
