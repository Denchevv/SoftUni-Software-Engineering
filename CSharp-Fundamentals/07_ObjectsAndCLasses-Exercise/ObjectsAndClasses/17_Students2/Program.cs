namespace _17_Students2
{
    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

    }
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] properties = Console.ReadLine().Split();

                string name = properties[0];
                string lastName = properties[1];
                double grade = double.Parse(properties[2]);

                Student student = new Student();
                student.Name = name;
                student.LastName = lastName;
                student.Grade = grade;

                list.Add(student);
            }

            list = list.OrderByDescending(x=>x.Grade).ToList();
            foreach (Student student in list)
            {
                Console.WriteLine($"{student.Name} {student.LastName}: {student.Grade}");
            }

        }
    }
}