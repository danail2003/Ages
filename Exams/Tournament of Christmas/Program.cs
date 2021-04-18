using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            double moneyPerDay = 0;
            int wonGames = 0;
            int lostGames = 0;
            int wonGamesPerDay = 0;
            int lostGamesPerDay = 0;

            for (int i = 0; i < days; i++)
            {
                string command = Console.ReadLine();

                while (command != "Finish")
                {
                    if (command == "win")
                    {
                        wonGames++;
                        wonGamesPerDay++;
                        moneyPerDay += 20;
                    }
                    else if (command == "lose")
                    {
                        lostGames++;
                        lostGamesPerDay++;
                    }

                    command = Console.ReadLine();
                }

                if (wonGamesPerDay > lostGamesPerDay)
                {
                    moneyPerDay += moneyPerDay * 0.1;
                    totalMoney += moneyPerDay;
                    moneyPerDay = 0;
                    wonGamesPerDay = 0;
                    lostGamesPerDay = 0;
                }
                else
                {
                    totalMoney += moneyPerDay;
                    moneyPerDay = 0;
                    wonGamesPerDay = 0;
                    lostGamesPerDay = 0;
                }
            }

            if (wonGames > lostGames)
            {
                totalMoney += totalMoney * 0.20;

                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
