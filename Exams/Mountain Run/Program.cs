using System;

namespace Mountain_Run
{
    class Program
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double allTime = timeInSeconds * distanceInMeters;
            double delay = Math.Floor(distanceInMeters / 50) * 30;

            allTime += delay;

            if (record > allTime) 
            {
                Console.WriteLine($"Yes! The new record is {allTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {allTime - record:f2} seconds slower.");
            }
        }
    }
}
