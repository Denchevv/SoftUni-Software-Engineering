namespace _01_SinoTheWalker
{
    public class Program
    {
        public static void Main()
        {
            string[] leftTime = Console.ReadLine().Split(':');
            int steps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());

            int hours = int.Parse(leftTime[0]); 
            int minutes = int.Parse(leftTime[1]); 
            int seconds = int.Parse(leftTime[2]); 

            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            int secondsToReachHome = steps * secondsPerStep;
            int neededSeconds = totalSeconds + secondsToReachHome;

            int resultHour = neededSeconds / 3600;
            int resultMinutes = neededSeconds % 3600 / 60;
            int resultSeconds = neededSeconds % 3600 % 60;

            string result = string.Empty;

            if(resultHour >= 24) 
            {
                resultHour -= 24;
            }

            Console.WriteLine($"Time Arrival: {resultHour:d2}:{resultMinutes:d2}:{resultSeconds:d2}");

        }
    }
}
