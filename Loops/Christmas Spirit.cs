using System;

namespace Christmas_Spirit
{
    class Program
    {
        static void Main()
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            
            int totalPrice = 0;
            int totalSpirit = 0;
            bool isThird = false;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }

                if (i % 2 == 0)
                {
                    totalPrice += (quantity * 2);
                    totalSpirit += 5;
                }

                if (i % 3 == 0)
                {
                    totalPrice += (quantity * 5) + (quantity * 3);
                    totalSpirit += 13;
                    isThird = true;
                }

                if (i % 5 == 0)
                {
                    totalPrice += (quantity * 15);
                    totalSpirit += 17;

                    if (isThird)
                    {
                        totalSpirit += 30;
                    }
                }

                isThird = false;

                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    totalPrice += 5 + 3 + 15;

                    if (i == 10 && days % 10 == 0)
                    {
                        totalSpirit -= 30;
                    }
                }                
            }

            Console.WriteLine($"Total cost: {totalPrice}");
            Console.WriteLine($"Total spirit: {totalSpirit}");
        }
    }
}
