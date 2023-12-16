namespace _12_CompanyUsers
{
    public class Program
    {
        public static void Main()
        {
            var companyReg = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "End")
                {
                    break;
                }

                string[] data = line.Split("->");

                string companyName = data[0];
                string empleyeeID = data[1];

                if (!companyReg.ContainsKey(companyName))
                {
                    companyReg.Add(companyName, new List<string>());
                    companyReg[companyName].Add(empleyeeID);
                }
                else
                {
                    if (!companyReg[companyName].Contains(empleyeeID))
                    {
                        companyReg[companyName].Add(empleyeeID);
                    }
                }
            }
            
            foreach(var kvp in companyReg)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var employeeID in kvp.Value)
                {
                    Console.WriteLine($"--{employeeID}");
                }
            }
        }
    }
}