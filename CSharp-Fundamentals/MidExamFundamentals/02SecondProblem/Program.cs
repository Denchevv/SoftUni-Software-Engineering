using System.Threading.Channels;

namespace _02SecondProblem
{
    internal class Program
    {
        static void Main()
        {
            List<string> coffeeList = Console.ReadLine()
                               .Split(" ")
                               .ToList();

            int coffeeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < coffeeCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string command = tokens[0];

                if (command == "Include")
                {
                    string typeCoffee = tokens[1];
                    coffeeList.Add(typeCoffee);              

                }
                if(command == "Remove")
                {
                    string secondToken = tokens[1];
                    int positions = int.Parse(tokens[2]); 

                    if(positions > coffeeList.Count)
                    {
                        continue;
                    }
                    else
                    {

                        if(secondToken == "first")
                        {              
                            for (int start = 0; start < positions; start++)
                            {
                                coffeeList.RemoveAt(0);
                            }
                            
                        }
                        else
                        {
                            for(int start = 0;start < positions; start++)
                            {
                                int lastIndex = coffeeList.Count - 1;
                                coffeeList.RemoveAt(lastIndex);
                            }
                        }

                    }             
                }
                if (command == "Prefer")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    
                    if(firstIndex <= coffeeList.Count && secondIndex <= coffeeList.Count)
                    {
                        string temp = coffeeList[firstIndex];
                        coffeeList[firstIndex] = coffeeList[secondIndex];
                        coffeeList[secondIndex] = temp;
                            
                        
                    }
                    
                }
                if(command == "Reverse")
                {
                    coffeeList.Reverse();
                }

            }

            Console.WriteLine($"Coffees: ");
            Console.WriteLine($"{string.Join(" ", coffeeList)}");

        }

    }
}