namespace _08_OrderByAge
{
    class People
    {
        public People(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }

        public int Age { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<People> list = new List<People>();
            while(true)
            {
                string line = Console.ReadLine();
                if(line == "End")
                {
                    break;
                }

                string[] data = line.Split();

                string name = data[0];
                string iD = data[1];
                int age = int.Parse(data[2]);

                People people = new People(name,iD,age);
                list.Add(people);
            }

            
            List<People> orderedList = list.OrderBy(x => x.Age).ToList();
            if (orderedList.Count > 0)
            {
                foreach (People people in orderedList)
                {
                    Console.WriteLine($"{people.Name} with ID: {people.ID} is {people.Age} years old.");
                }
            }
        }
    }
}