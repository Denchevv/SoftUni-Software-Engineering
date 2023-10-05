int studentTickets = 0;
int standartTickets = 0;
int kidsTickets = 0;

string movieName;

while ((movieName = Console.ReadLine()) != "Finish")
{
    int freeSits = int.Parse(Console.ReadLine());
    int ticketsPerMovie = 0;

    string ticketsType;
    while (freeSits > ticketsPerMovie && (ticketsType = Console.ReadLine()) != "End")
    {
        if (ticketsType == "student") { studentTickets++; }
        else if (ticketsType == "standard") { standartTickets++; }
        else { kidsTickets++; }

        ticketsPerMovie++;
    }
        
        Console.WriteLine($"{movieName} - {1.0 * ticketsPerMovie / freeSits * 100:f2}% full.");
}
int totalTickets = standartTickets + studentTickets + kidsTickets;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{1.0 * studentTickets / totalTickets * 100:f2}% student tickets.");
Console.WriteLine($"{1.0 * standartTickets / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{1.0 * kidsTickets / totalTickets * 100:f2}% kids tickets.");