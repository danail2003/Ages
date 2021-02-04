using System;

namespace Party_Profit
{
    class Program
    {
        static void Main()
        {
            int party = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            
            int coins = 0;
            bool isThird = false;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    party -= 2;
                }

                if (i % 15 == 0)
                {
                    party += 5;
                }

                coins += 50;
                coins -= (party * 2);

                if (i % 3 == 0)
                {
                    coins -= (party * 3);
                    isThird = true;
                }

                if (i % 5 == 0)
                {
                    coins += (party * 20);

                    if (isThird)
                    {
                        coins -= (party * 2);
                    }
                }

                isThird = false;
            }

            int coinsForCompany = coins / party;
            Console.WriteLine($"{party} companions received {coinsForCompany} coins each.");
        }
    }
}
