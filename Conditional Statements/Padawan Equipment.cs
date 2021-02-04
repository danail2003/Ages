using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            
            double freeBelts = countOfStudents / 6;
            double totalLightsabers = priceOfLightsabers * Math.Ceiling(countOfStudents * 1.10);
            double totalRobes = priceOfRobes * countOfStudents;
            double totalBelts = priceOfBelts * (countOfStudents - freeBelts);
            double total = totalBelts + totalLightsabers + totalRobes;

            if (budget >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                double diff = total - budget;
                Console.WriteLine($"Ivan Cho will need {diff:f2}lv more.");
            }
        }
    }
}
