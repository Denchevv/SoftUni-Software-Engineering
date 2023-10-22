namespace _01FirstProblem
{
    internal class Program
    {
        //500 5 50 100 200 100 30 
        static void Main()
        {
            
            double experienceNeeded = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());

            double currentExp = 0;

            for (int i = 1; i <= battlesCount; i++)
            {
                double expPerBattle = double.Parse(Console.ReadLine());

                if(i % 3 == 0)
                {
                    expPerBattle *= 1.15;
                }
                if(i % 5 == 0)
                {
                    expPerBattle *= 0.9;
                }
                if(i % 15 == 0)
                {
                    expPerBattle *= 1.05;
                }
                currentExp += expPerBattle;

                if (currentExp >= experienceNeeded)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }

            }
            Console.WriteLine($"Player was not able to collect the needed experience, " +
                              $"{experienceNeeded - currentExp:f2} more needed.");


        }
    }
}