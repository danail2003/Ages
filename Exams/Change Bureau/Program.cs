using System;

namespace Change_Bureau
{
    class Program
    {
        static void Main()
        {
            int bitcoinCount = int.Parse(Console.ReadLine());
            double yuanCount = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double totalLevs = (bitcoinCount * 1168) + (yuanCount * 0.15 * 1.76);
            totalLevs /= 1.95;

            double totalSum = totalLevs - (totalLevs * tax / 100);

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
