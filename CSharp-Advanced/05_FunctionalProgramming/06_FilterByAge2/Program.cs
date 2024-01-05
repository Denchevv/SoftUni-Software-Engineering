namespace _06_FilterByAge2
{
    public class Program
    {
        public static void Main()
        {
            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person,age) => person.age >= age;


        }
    }
}
