using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main()
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            
            double size = (l * 100);
            double size1 = (w * 100);
            double size2 = (a * 100);
            double size3 = (a * 100);
            double sizeOfHall = size * size1;
            double sizeOfWardrobe = (size2 * size3);
            double sizeOfBench = (sizeOfHall / 10);
            double freeSpace = sizeOfHall - sizeOfWardrobe - sizeOfBench;
            double countOfDancers = freeSpace / (40 + 7000);
            
            Console.WriteLine(Math.Floor(countOfDancers));
        }
    }
}
