using System.Collections.Generic;

namespace _12_KeyRevolver
{
    public class Program
    {
        public static void Main()
        {
            // Read Input

            int priceBullet = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();  
            int[] locks = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            int money = int.Parse(Console.ReadLine());


            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQue = new Queue<int>(locks);

            int shotsCount = 0;
        
            // While Loop - calculations 

            while(locksQue.Count > 0)
            {

                if(bulletsStack.Count <= 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locksQue.Count}");
                    return;
                }

                int bullet = bulletsStack.Pop();
                int currentLock = locksQue.Peek();

                shotsCount++;

                if(bullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locksQue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if(shotsCount % barrelSize == 0 && bulletsStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            int moneyEarned = money - (shotsCount * priceBullet);

            Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
        }


    }
}
