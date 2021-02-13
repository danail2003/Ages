using System;

namespace Spaceship
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double space = width * length * height;
            double spaceOfRoom = (averageHeight + 0.40) * 2 * 2;
            double astronauts = Math.Floor (space / spaceOfRoom);

            if (astronauts >= 3 && astronauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }
            else if (astronauts < 3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
