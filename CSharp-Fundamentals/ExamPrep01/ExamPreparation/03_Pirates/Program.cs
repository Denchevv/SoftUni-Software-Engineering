namespace _03_Pirates
{
    class City
    {
        public City(string name, int population, int gold)
        {
            CityName = name;
            Population = population;
            Gold = gold;
        }

        public string CityName {  get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
        
        
    }

    public class Program
    {
        public static void Main()
        {
            List<City> list = new List<City>();

           while (true)
            {
                string input = Console.ReadLine();
                if(input == "Sail")
                {
                    break;
                }

                string[] token = input.Split("||");

                string cityName = token[0];
                int people = int.Parse(token[1]);
                int gold = int.Parse(token[2]);

                bool cityExists = list.Any(x => x.CityName == cityName);

                if (cityExists)
                {
                    int indexOfCity = list.FindIndex(x=>x.CityName == cityName);

                    list[indexOfCity].Gold += gold;
                    list[indexOfCity].Population += people;
                }
                else
                {
                    City city = new City(cityName, people, gold);
                    list.Add(city);
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "End")
                {
                    break;
                }

                string[] token = line.Split("=>");

                string command = token[0];

                if(command == "Plunder")
                {
                    string cityName = token[1];
                    int people = int.Parse(token[2]);
                    int gold = int.Parse(token[3]);

                    int indexOfCity = list.FindIndex(x => x.CityName == cityName);

                    list[indexOfCity].Population -= people;
                    list[indexOfCity].Gold -= gold;

                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (list[indexOfCity].Population <= 0 || list[indexOfCity].Gold <= 0)
                    {
                        list.Remove(list[indexOfCity]);

                        Console.WriteLine($"{cityName} has been wiped off the map!");
                    }

                }
                else if(command == "Prosper")
                {
                    string cityName = token[1];
                    int gold = int.Parse(token[2]);

                    if(gold <= 0 ) 
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        int indexOfCity = list.FindIndex(x=>x.CityName == cityName);
                        list[indexOfCity].Gold += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury." +
                                          $" {cityName} now has {list[indexOfCity].Gold} gold.");
                    }             
                }
            }

            if(list.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {list.Count} wealthy settlements to go to:");

                foreach(City kvp in list)
                {
                    Console.WriteLine($"{kvp.CityName} -> Population: {kvp.Population} citizens, Gold: {kvp.Gold} kg");
                }
            }


        }
    }
}