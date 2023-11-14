namespace _10_OldestFamilyMember
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public List<Person> FamilyList { get; set; } = new List<Person>();

        public void AddMember(string name, int age)
        {
            FamilyList.Add(new Person(name, age));
        }

        public Person GetOldest()
        {
            if (FamilyList.Count == 0)
            {
                return null;
            }
            return FamilyList.OrderByDescending(x => x.Age).First();
        }

    }
    public class Program
    {
        public static void Main()
        {
            int numOfMembers = int.Parse(Console.ReadLine());
            Family myFamily = new Family();

            for (int i = 0; i < numOfMembers; i++)
            {
                string[] data = Console.ReadLine().Split();

                string name = data[0];
                int age = int.Parse(data[1]);

                myFamily.AddMember(name, age);
            }

            Person oldestPerson = myFamily.GetOldest();
            if(oldestPerson!= null)
            {
                Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            }
           
        }
    }
}