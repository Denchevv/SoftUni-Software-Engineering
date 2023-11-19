namespace _10_Courses
{
    public class Program
    {
        public static void Main()
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] data = line.Split((" :"), StringSplitOptions.RemoveEmptyEntries);
                string courseName = data[0];
                string studentName = data[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
            }

            foreach (var kvp in courses)                                        
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value) 
                {
                    Console.WriteLine($"--{student}");
                }
            }
        }
    }
}
