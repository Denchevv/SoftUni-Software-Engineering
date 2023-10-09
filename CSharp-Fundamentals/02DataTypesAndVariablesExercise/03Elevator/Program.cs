int peopleCount = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());


int courses = peopleCount / capacity;

if (peopleCount % capacity != 0)
{
    courses++;
}

Console.WriteLine(courses);
