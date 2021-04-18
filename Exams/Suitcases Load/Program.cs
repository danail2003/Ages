using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main()
        {
            double capacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int counter = 0;
            bool isVolumeBigger = false;

            while (command != "End")
            {
                double volume = double.Parse(command);

                if ((counter + 1) % 3 == 0)
                {
                    volume *= 1.10;
                }

                if (capacity >= volume)
                {
                    capacity -= volume;
                    counter++;
                }
                else
                {
                    isVolumeBigger = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isVolumeBigger)
            {
                Console.WriteLine("No more space!");
            }
            else
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
