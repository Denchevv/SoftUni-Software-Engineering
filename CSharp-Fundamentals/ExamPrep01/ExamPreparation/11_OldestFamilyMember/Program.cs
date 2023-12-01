namespace _11_OldestFamilyMember
{
    class Person
    {
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public List<Person> List { get; set; } = new List<Person> ();

        public void AddMember (string name, int age)
        {
            List.Add (new Person(name, age));
        }

        public Person GetOldestMember ()
        {
            if (List.Count == 0)
            {
                return null;
            }
            return List.OrderByDescending(x=>x.Age).First();

        }
    }

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Family myFamily = new Family ();

            for (int i = 0; i < number; i++)
            {
                string[] data = Console.ReadLine().Split();

                myFamily.AddMember(data[0], int.Parse(data[1]));               
            }

            Person oldestPerson = myFamily.GetOldestMember();

            if(oldestPerson != null)
            {
                Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            }
        }
    }
}