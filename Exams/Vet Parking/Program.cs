using System;

namespace Vet_Parking
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double pricePerDay = 0;
            double totalPrice = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 != 0 && j % 2 != 0)
                    {
                        pricePerDay += 1;
                    }
                    else if (i % 2 == 0 && j % 2 != 0)
                    {
                        pricePerDay += 2.50;
                    }
                    else
                    {
                        pricePerDay += 1.25;
                    }
                }

                Console.WriteLine($"Day: {i} - {pricePerDay:f2} leva");

                totalPrice += pricePerDay;
                pricePerDay = 0;
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
