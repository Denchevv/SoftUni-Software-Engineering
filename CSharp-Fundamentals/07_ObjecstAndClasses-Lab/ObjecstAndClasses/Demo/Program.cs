namespace Demo
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }

    }
    public class Program
    {
        static void Main()
        {
            List<Student> listStudents = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] data = line.Split();

                string firstName = data[0];
                string lastName = data[1];
                string age = data[2];
                string city = data[3];

                if (DoesTheStudentExist(listStudents, firstName, lastName))
                {
                    Student student = OverwritingStudentsInfo(listStudents, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };

                    listStudents.Add(student);
                }
            }
            string filterCity = Console.ReadLine();

            foreach (Student student in listStudents)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static Student OverwritingStudentsInfo(List<Student> listStudents, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in listStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

            static bool DoesTheStudentExist(List<Student> listStudent, string firstName, string lastName)
            {
                foreach (Student student in listStudent)
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
