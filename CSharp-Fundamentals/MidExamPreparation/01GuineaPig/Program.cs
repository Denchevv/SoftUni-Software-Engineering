using System.Drawing;

namespace _01GuineaPig
{
    internal class Program
    {
        static void Main()
        {
            double foodKg = double.Parse(Console.ReadLine());
            double hayKg = double.Parse(Console.ReadLine());
            double coverKg = double.Parse(Console.ReadLine());
            double pigsWeight = double.Parse(Console.ReadLine());

            double foodInGrams = foodKg * 1000;
            double hayInGrams = hayKg * 1000;
            double coverInGrams = coverKg * 1000;
            double pigInGrams = pigsWeight * 1000;
            bool notEnough = false;

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams -= 300;

                if(i % 2 == 0)
                {
                    hayInGrams -= 0.05 * foodInGrams;
                }

                if(i % 3 == 0)
                {
                    coverInGrams -= (pigInGrams / 3.0);
                }


                if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0) 
                {
                   
                    notEnough = true;
                    break;
                    

                }

            }

            foodKg = foodInGrams / 1000;
            hayKg = hayInGrams / 1000;
            coverKg = coverInGrams/ 1000;

            
            if (notEnough)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy!" +
                                   $" Food: {foodKg:f2}, " +
                                   $"Hay: {hayKg:f2}, " +
                                   $"Cover: {coverKg:f2}.");
            }
        }
    }
}