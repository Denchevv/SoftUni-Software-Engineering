namespace _06_HeroesAndLogic
{
    class Hero
    {
        public Hero(string name, int health, int manaPoints)
        {
            HeroName = name;
            Health = health;
            ManaPoints = manaPoints;
        }
        public string HeroName { get; set; }
        public int Health { get; set; }
        public int ManaPoints { get; set; }

    }
    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            List<Hero> list = new List<Hero>();

            for (int i = 0; i < range; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int health = int.Parse(input[1]);
                int manaPoints = int.Parse(input[2]);

                Hero hero = new Hero(name, health, manaPoints);

                list.Add(hero);
            }

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] token = line.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = token[0];
                string heroName = token[1];

                int indexOfHero = list.FindIndex(x => x.HeroName == heroName);


                if (command == "CastSpell")
                {
                    int manaNeeded = int.Parse(token[2]);
                    string spellName = token[3];

                    int manaAvailable = list[indexOfHero].ManaPoints;

                    if (manaNeeded <= manaAvailable)
                    {
                        list[indexOfHero].ManaPoints -= manaNeeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {list[indexOfHero].ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }


                }
                else if (command == "TakeDamage")
                {
                    int healthDamage = int.Parse(token[2]);
                    string attackerName = token[3];

                    list[indexOfHero].Health -= healthDamage;

                    if (list[indexOfHero].Health <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attackerName}!");
                        list.Remove(list[indexOfHero]);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {healthDamage} HP by " +
                            $"{attackerName} and now has {list[indexOfHero].Health} HP left!");
                    }
                }
                else if (command == "Recharge")
                {
                    int manaAmount = int.Parse(token[2]);
                    int originalMana = list[indexOfHero].ManaPoints;

                    list[indexOfHero].ManaPoints += manaAmount;

                    if (list[indexOfHero].ManaPoints > 200)
                    {
                        manaAmount = 200 - originalMana;
                        list[indexOfHero].ManaPoints = 200;

                    }

                    Console.WriteLine($"{heroName} recharged for {manaAmount} MP!");

                }
                else if (command == "Heal")
                {
                    int healthAmount = int.Parse(token[2]);
                    int originalHealth = list[indexOfHero].Health;

                    list[indexOfHero].Health += healthAmount;

                    if(list[indexOfHero].Health > 100)
                    {
                        healthAmount = 100 - originalHealth;
                        list[indexOfHero].Health = 100;
                    }

                    Console.WriteLine($"{heroName} healed for {healthAmount} HP!");
                }
            }

            foreach (var kvp in list)
            {
                string heroName = kvp.HeroName;
                int health = kvp.Health;
                int manaPoints = kvp.ManaPoints;

                Console.WriteLine(heroName);
                Console.WriteLine($"  HP: {health}");
                Console.WriteLine($"  MP: {manaPoints}");

            }
           

        }
    }
}