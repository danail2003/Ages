using System;

namespace Cooking_Masterclass
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfFlour = double.Parse(Console.ReadLine());
            double priceOfEgg = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());
            
            int flourCounter = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    flourCounter++;
                }
            }

            double apronMoney = priceOfApron * Math.Ceiling(students * 1.20);
            double eggMoney = priceOfEgg * 10 * students;
            double flourMoney = priceOfFlour * (students - flourCounter);
            double neededMoney = apronMoney + eggMoney + flourMoney;

            if (neededMoney <= budget)
            {
                Console.WriteLine($"Items purchased for {neededMoney:f2}$.");
            }
            else
            {
                double diff = neededMoney - budget;
                Console.WriteLine($"{diff:f2}$ more needed.");
            }
        }
    }
}
