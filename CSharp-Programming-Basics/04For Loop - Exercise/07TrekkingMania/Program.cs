//1. Read input
int groupsCount = int.Parse(Console.ReadLine());

int musala = 0; int montblan = 0; int kilimandjaro = 0; int k2 = 0; int everest = 0;

//2. Calculate the %

int totalPeople = 0;
for (int i = 1; i <= groupsCount; i++)
{
    int peopleInGroup = int.Parse(Console.ReadLine());
    totalPeople += peopleInGroup;

    if (peopleInGroup <= 5) { musala+= peopleInGroup; }
    else if (peopleInGroup < 13) { montblan+= peopleInGroup; }
    else if (peopleInGroup < 26) { kilimandjaro+= peopleInGroup; }
    else if (peopleInGroup < 41) { k2+= peopleInGroup; }
    else  { everest+= peopleInGroup; }

}
//3. Print output
Console.WriteLine($"{100.0 * musala / totalPeople:f2}%");
Console.WriteLine($"{100.0 * montblan / totalPeople:f2}%");
Console.WriteLine($"{100.0 * kilimandjaro / totalPeople:f2}%");
Console.WriteLine($"{100.0 * k2 / totalPeople:f2}%");
Console.WriteLine($"{100.0 * everest / totalPeople:f2}%");