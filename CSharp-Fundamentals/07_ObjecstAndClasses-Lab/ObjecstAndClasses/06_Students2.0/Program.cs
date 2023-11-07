namespace _06_Students2._0
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

                if (IsStudentExisting(list, firstName, secondName))
                {
                    Student student = GetStudent(list, firstName, secondName);
                    
                    student.FirstName = firstName;
                    student.LastName =  secondName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = secondName,
                        Age = age,
                        HomeTown = homeTown
                    };

                    list.Add(student);

                }
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in list)
            {
                if (filterCity == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

                }
            }
        }

        private static Student GetStudent(List<Student> list, string firstName, string secondName)
        {
            Student existingStudent = null;
            
            foreach (Student student in list)
            {
                if(student.FirstName == firstName && student.LastName == secondName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool IsStudentExisting(List<Student> list, string firstName, string lastName)
        {
            foreach (Student student in list)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}