namespace _11_StudentAcademy
{
    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < range; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }
                students[studentName].Add(grade);
            }

            Dictionary<string, List<double>> finalStudents = students
                                            .Where(x => x.Value.Average() >= 4.50)
                                            .ToDictionary(a => a.Key, a => a.Value);

            foreach (var student in finalStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}