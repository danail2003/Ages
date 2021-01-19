using System;

namespace Football_Souvenirs
{
    class Program
    {
        static void Main()
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int countOfSouvenir = int.Parse(Console.ReadLine());
            
            double price = 0;           

            if (team == "Argentina")
            {
                if (souvenir == "flags")
                {
                    price = countOfSouvenir * 3.25;
                }
                else if (souvenir == "caps")
                {
                    price = countOfSouvenir * 7.20;
                }
                else if (souvenir == "posters")
                {
                    price = countOfSouvenir * 5.10;
                }
                else if (souvenir == "stickers")
                {
                    price = countOfSouvenir * 1.25;
                }
            }
            else if (team == "Brazil")
            {
                if (souvenir == "flags")
                {
                    price = countOfSouvenir * 4.20;
                }
                else if (souvenir == "caps")
                {
                    price = countOfSouvenir * 8.50;
                }
                else if (souvenir == "posters")
                {
                    price = countOfSouvenir * 5.35;
                }
                else if (souvenir == "stickers")
                {
                    price = countOfSouvenir * 1.20;
                }
            }
            else if (team == "Croatia")
            {
                if (souvenir == "flags")
                {
                    price = countOfSouvenir * 2.75;
                }
                else if (souvenir == "caps")
                {
                    price = countOfSouvenir * 6.90;
                }
                else if (souvenir == "posters")
                {
                    price = countOfSouvenir * 4.95;
                }
                else if (souvenir == "stickers")
                {
                    price = countOfSouvenir * 1.10;
                }
            }
            else if (team == "Denmark")
            {
                if (souvenir == "flags")
                {
                    price = countOfSouvenir * 3.10;
                }
                else if (souvenir == "caps")
                {
                    price = countOfSouvenir * 6.50;
                }
                else if (souvenir == "posters")
                {
                    price = countOfSouvenir * 4.80;
                }
                else if (souvenir == "stickers")
                {
                    price = countOfSouvenir * 0.90;
                }
            }
           
            if(team != "Argentina" && team != "Brazil" && team != "Croatia" && team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
            else if(souvenir != "flags" && souvenir != "caps" && souvenir != "posters" && souvenir != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {countOfSouvenir} {souvenir} of {team} for {price:f2} lv.");
            }
        }
    }
}
