using System;

namespace Shopping
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramMemorys = int.Parse(Console.ReadLine());

            double priceForVideocards = videocards * 250;
            double processorPercent = priceForVideocards * 0.35;
            double priceForProcessors = processorPercent * processors;
            double ramMemoryPercent = priceForVideocards * 0.10;
            double priceForRam = ramMemoryPercent * ramMemorys;
            double total = priceForVideocards + priceForProcessors + priceForRam;

            if (videocards > processors)
            {
                total *= 0.85;
            }
            
            double diff = Math.Abs(budget - total);

            if (budget >= total)
            {
                Console.WriteLine($"You have {diff:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva more!");
            }
        }
    }
}
