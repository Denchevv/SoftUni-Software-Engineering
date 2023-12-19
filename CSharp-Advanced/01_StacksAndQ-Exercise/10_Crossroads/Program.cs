using System.Runtime.InteropServices;

namespace _10_Crossroads
{
    public class Program
    {
        public static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            var carsQue = new Queue<string>();

            int totalCarsPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                int greenLightLeft = greenLight;
                int freeWindowLeft = freeWindow;

                if (input == "END")
                {
                    Console.WriteLine($"Everyone is safe.{Environment.NewLine}" +
                        $"{totalCarsPassed} total cars passed the crossroads.");
                }
                else if (input == "green")
                {
                    while (greenLightLeft > 0 && carsQue.Count > 0)
                    {
                        string car = carsQue.Dequeue();
                        greenLightLeft -= car.Length;

                        if (greenLightLeft >0)
                        {
                            totalCarsPassed++;
                        }
                        else
                        {
                            freeWindowLeft += greenLightLeft;

                            if (freeWindowLeft < 0)
                            {
                                char letterCrashed = car[car.Length + freeWindowLeft];
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                    $"{car} was hit at {letterCrashed}.");
                                return;
                            }

                            totalCarsPassed++;
                        }
                    }
                }
                else
                {
                    carsQue.Enqueue(input);
                }

            }

        }
    }
}
