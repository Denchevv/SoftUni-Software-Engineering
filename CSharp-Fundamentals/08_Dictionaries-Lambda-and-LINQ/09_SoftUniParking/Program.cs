namespace _09_SoftUniParking
{
    public class Program
    {
        public static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, string>();

            for (int i = 0; i < commands; i++)
            {
                string[] firstInput = Console.ReadLine().Split();

                string command = firstInput[0];
                string name = firstInput[1];

                if (command == "register")
                {
                    string licenseNum = firstInput[2];

                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNum}");
                    }
                    else
                    {
                        users.Add(name, licenseNum);
                        Console.WriteLine($"{name} registered {licenseNum} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (users.ContainsKey(name))
                    {
                        users.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }      
            }
            foreach (var kvp in users)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}