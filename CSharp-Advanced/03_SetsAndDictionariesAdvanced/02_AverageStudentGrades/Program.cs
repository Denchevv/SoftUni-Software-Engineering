namespace _02_AverageStudentGrades
{
    public class Program
    {
        public static void Main()
        {
            int studentsNum = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < studentsNum; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string studentName = data[0];
                decimal grade = decimal.Parse(data[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }
                    students[studentName].Add(grade);
            }

            foreach (var kvp in students)
            {
                
                string formattedGrades = string.Join(" ", kvp.Value.Select(grades=>grades.ToString("F2")));

                Console.WriteLine($"{kvp.Key} -> {formattedGrades} (avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
