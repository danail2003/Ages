using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main()
        {
            int kilogramsFood = int.Parse(Console.ReadLine());

            int foodInGrams = kilogramsFood * 1000;

            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int quantityOfFood = int.Parse(command);

                foodInGrams -= quantityOfFood;

                command = Console.ReadLine();
            }

            if (foodInGrams >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodInGrams)} grams more.");
            }
        }
    }
}
