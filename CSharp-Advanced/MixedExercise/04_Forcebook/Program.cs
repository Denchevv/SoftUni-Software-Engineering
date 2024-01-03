namespace _04_Forcebook
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> sideUsers = new Dictionary<string, List<string>>();
            Dictionary<string, string> userSide = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains('|'))
                {
                    string[] tokens = line.Split(" | ");

                    string side = tokens[0];
                    string user = tokens[1];
                    // Case 1 - not existing user, not existing side
                    if (userSide.ContainsKey(user) == false)
                    {
                        if (sideUsers.ContainsKey(side) == false)
                        {
                            sideUsers[side] = new List<string>();
                        }
                        sideUsers[side].Add(user);
                        userSide[user] = side;
                    }
                }
                else
                {
                    string[] tokens2 = line.Split(" -> ");

                    string user = tokens2[0];
                    string side = tokens2[1];

                    if (userSide.ContainsKey(user))  // User exists
                    {
                        if (userSide[user].Contains(side) == false) // Case 1 - existing user with different side
                        {
                            sideUsers[userSide[user]].Remove(user); // remove the user from the existing side-List
                            userSide[user] = side;
                            if (sideUsers.ContainsKey(side) == false)
                            {
                                sideUsers[side] = new List<string>();
                            }
                            sideUsers[side].Add(user); // add the user to the new side

                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                    else if (userSide.ContainsKey(user) == false) // User doesn`t exist
                    {
                        if (sideUsers.ContainsKey(side) == false) // Case 2 - User doesnt exist and side doesn`t exist
                        {
                            userSide[user] = side;
                            sideUsers[side] = new List<string>() { user };
                        }
                        else // Case 3 - user doesnt exists side exists
                        {
                            userSide[user] = side;
                            sideUsers[side].Add(user);
                        }
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }

            var orderedDict = sideUsers
                    .Where(u => u.Value.Count > 0)
                    .OrderByDescending(u => u.Value.Count)
                    .ThenBy(u => u.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedDict)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                foreach (var users in kvp.Value.OrderBy(name=>name))
                {
                    Console.WriteLine($"! {users}");
                }
            }
        }
    }
}
