using System;

namespace Fitness_Card
{
    class Program
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;
            double percent = 0;

            if (age <= 19)
            {
                percent = 20;
            }

            if (gender == 'f')
            {
                if (sport == "Gym")
                {
                    price = 35 - (35 * percent / 100);
                }
                else if (sport == "Boxing")
                {
                    price = 37 - (37 * percent / 100);
                }
                else if (sport == "Yoga")
                {
                    price = 42 - (42 * percent / 100);
                }
                else if (sport == "Zumba")
                {
                    price = 31 - (31 * percent / 100);
                }
                else if (sport == "Dances")
                {
                    price = 53 - (53 * percent / 100);
                }
                else if (sport == "Pilates")
                {
                    price = 37 - (37 * percent / 100);
                }
            }
            else if (gender == 'm')
            {
                if (sport == "Gym")
                {
                    price = 42 - (42 * percent / 100);
                }
                else if (sport == "Boxing")
                {
                    price = 41 - (41 * percent / 100);
                }
                else if (sport == "Yoga")
                {
                    price = 45 - (45 * percent / 100);
                }
                else if (sport == "Zumba")
                {
                    price = 34 - (34 * percent / 100);
                }
                else if (sport == "Dances")
                {
                    price = 51 - (51 * percent / 100);
                }
                else if (sport == "Pilates")
                {
                    price = 39 - (39 * percent / 100);
                }
            }

            if (amount >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${price - amount:f2} more.");
            }
        }
    }
}
