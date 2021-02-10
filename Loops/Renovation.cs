using System;

namespace Renovation
{
    class Program
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int noPaint = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            double area = height * width * 4;
            double walls = area - (area * noPaint/100);           
            int liters = 0;
            double wallsForPaint = walls;
            int allWalls = 0;

            while (command != "Tired!")
            {
                if (command != "Tired!")
                {
                    liters = int.Parse(command);
                }

                walls -= liters;
                allWalls += liters;

                if (allWalls > wallsForPaint)
                {
                    Console.WriteLine($"All walls are painted and you have { Math.Abs(walls)} l paint left!");
                    break;
                }
                else if (wallsForPaint == allWalls)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Tired!")
            {
                Console.WriteLine($"{walls} quadratic m left.");
            }           
        }
    }
}
