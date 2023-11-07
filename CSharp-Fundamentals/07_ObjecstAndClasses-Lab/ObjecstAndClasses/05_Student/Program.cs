namespace _05_Student
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }
    public class Program
    {
        static void Main()
        {
            List<Student> list = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                List<string> data = line.Split().ToList();
                
                string firstName = data[0];
                string secondName = data[1];
                string age = data[2];
                string homeTown = data[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = secondName;
                student.Age = age;
                student.HomeTown = homeTown;

                list.Add(student);
            }

            string filterCity = Console.ReadLine();
            
            foreach(Student student in list)
            {
                if(filterCity == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
            
        }
    }
}