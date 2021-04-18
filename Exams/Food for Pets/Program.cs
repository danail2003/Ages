using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());

            double totalEatenFood = 0;
            double totalEatenFoodByDog = 0;
            double totalEatenFoodByCat = 0;
            double biscuitsQuantity = 0;


            for (int i = 1; i <= days; i++)
            {
                double eatenFoodByDog = double.Parse(Console.ReadLine());
                double eatenFoodByCat = double.Parse(Console.ReadLine());

                totalEatenFood += eatenFoodByCat + eatenFoodByDog;
                totalEatenFoodByDog += eatenFoodByDog;
                totalEatenFoodByCat += eatenFoodByCat;

                if (i % 3 == 0)
                {
                    double totalEatenFoodPerDay = eatenFoodByDog + eatenFoodByCat;
                    biscuitsQuantity += totalEatenFoodPerDay * 0.1;
                }
            }

            double percentOfEatenFood = totalEatenFood / foodQuantity * 100;
            double percentOfEatenFoodByDog = totalEatenFoodByDog / totalEatenFood * 100;
            double percentOfEatenFoodByCat = totalEatenFoodByCat / totalEatenFood * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuitsQuantity)}gr.");
            Console.WriteLine($"{percentOfEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentOfEatenFoodByDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentOfEatenFoodByCat:f2}% eaten from the cat.");
        }
    }
}
