string name = Console.ReadLine();
int projectsNum = int.Parse(Console.ReadLine());

int hoursNeeded = projectsNum * 3;

Console.WriteLine($" The architect {name} will need {hoursNeeded} hours to complete {projectsNum} project/s.");