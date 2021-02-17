using System;

namespace The_Hunting_Games
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());

            double neededWater = days * people * waterPerDay;
            double neededFood = days * people * foodPerDay;

            for (int i = 1; i <= days; i++)
            {
                double lostEnergy = double.Parse(Console.ReadLine());
                
                energy -= lostEnergy;

                if (energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {neededFood:f2} food and {neededWater:f2} water.");
                    return;
                }

                if (i % 2 == 0)
                {
                    energy += (energy * 0.05);
                    neededWater *= 0.7;
                }

                if (i % 3 == 0)
                {
                    energy += (energy * 0.1);
                    neededFood -= (neededFood / people);
                }
            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
        }
    }
}
