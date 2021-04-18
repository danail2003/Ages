using System;

namespace Cat_Walking
{
    class Program
    {
        static void Main()
        {
            int minutes = int.Parse(Console.ReadLine());
            int countOfTrips = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            double burntCalories = minutes * 5 * countOfTrips;

            double percent = burntCalories / caloriesPerDay * 100;

            if (percent >= 50)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burntCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burntCalories}.");
            }
        }
    }
}
