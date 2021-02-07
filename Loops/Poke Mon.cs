using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhausted = int.Parse(Console.ReadLine());
            
            int diff = power;
            int counter = 0;

            while (power >= distance)
            {                
                power -= distance;

                if (diff * 0.5 == power && exhausted > 0)
                {
                    power /= exhausted;
                }
                counter++;
            }

            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
