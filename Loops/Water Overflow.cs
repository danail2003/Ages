using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            
            int sum = 0;
            int counter = 0;

            while (counter < count)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= liters;
                }

                counter++;
            }
            
            Console.WriteLine(sum);
        }
    }
}
