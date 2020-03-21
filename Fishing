using System;

namespace Fishing
{
    class Program
    {
        static void Main()
        {
            int quota = int.Parse(Console.ReadLine());
            int counter = 0;
            double profit = 0;
            double all = 0;
            double loss = 0;
            double total = 0;
            string fish = Console.ReadLine();

            while (fish != "Stop" && counter != quota)
            {
                double weight = double.Parse(Console.ReadLine());
                counter++;

                for (int i = 0; i < fish.Length; i++)
                {
                    int price = fish[i];
                    loss += price;
                }

                if (counter == quota)
                {
                    profit += loss;
                    total = profit / weight;
                    Console.WriteLine("Lyubo fulfilled the quota!");
                }
                else
                {
                    double diff = loss / weight;
                    all += diff;
                    loss = 0;
                }

                if (fish != "Stop")
                {
                    fish = Console.ReadLine();
                }
            }

            if (total > all)
            {
                double end = total - all;
                Console.WriteLine($"Lyubo's profit from {counter} fishes is {end:f2} leva.");
            }
            else
            {
                double end = all - total;
                Console.WriteLine($"Lyubo lost {Math.Abs(end):f2} leva today.");
            }
        }
    }
}
