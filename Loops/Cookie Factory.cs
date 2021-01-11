using System;

namespace Cookie_factory
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            bool hasFlour = false;
            bool hasEggs = false;
            bool hasSugar = false;
            int counter = 0;
            bool hasAll = false;

            while(number > counter)
            {
                while (command != "Bake!" || hasAll == false)
                {
                    if (command == "eggs")
                    {
                        hasEggs = true;
                    }
                    else if (command == "sugar")
                    {
                        hasSugar = true;
                    }
                    else if (command == "flour")
                    {
                        hasFlour = true;
                    }

                    hasAll = hasEggs && hasFlour && hasSugar;

                    if (command == "Bake!" && hasAll == false)
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }

                    command = Console.ReadLine();
                }

                Console.WriteLine($"Baking batch number {counter + 1}...");

                hasSugar = false;
                hasFlour = false;
                hasEggs = false;

                counter++;

                if (counter < number)
                {
                    command = Console.ReadLine();
                }
            }
        }
    }
}
