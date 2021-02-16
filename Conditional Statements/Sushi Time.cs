using System;

namespace Sushi_Time
{
    class Program
    {
        static void Main()
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int countOfSushi = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double price;
            if (sushi == "sashimi")
            {
                if (restaurant == "Sushi Zone")
                {
                    price = countOfSushi * 4.99;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Time")
                {
                    price = countOfSushi * 5.49;

                    if (symbol == 'Y')
                    {
                        price *= 1.20;
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Bar")
                {
                    price = countOfSushi * 5.25;

                    if (symbol == 'Y')
                    {
                        price *= 1.20;
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Asian Pub")
                {
                    price = countOfSushi * 4.50;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else
                {
                    Console.WriteLine($"{restaurant} is invalid restaurant!");
                }
            }
            else if (sushi == "maki")
            {
                if (restaurant == "Sushi Zone")
                {
                    price = countOfSushi * 5.29;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Time")
                {
                    price = countOfSushi * 4.69;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Bar")
                {
                    price = countOfSushi * 5.55;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Asian Pub")
                {
                    price = countOfSushi * 4.80;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else
                {
                    Console.WriteLine($"{restaurant} is invalid restaurant!");
                }
            }
            else if (sushi == "uramaki")
            {
                if (restaurant == "Sushi Zone")
                {
                    price = countOfSushi * 5.99;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Time")
                {
                    price = countOfSushi * 4.49;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Bar")
                {
                    price = countOfSushi * 6.25;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Asian Pub")
                {
                    price = countOfSushi * 5.50;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else
                {
                    Console.WriteLine($"{restaurant} is invalid restaurant!");
                }
            }
            else if (sushi == "temaki")
            {
                if (restaurant == "Sushi Zone")
                {
                    price = countOfSushi * 4.29;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Time")
                {
                    price = countOfSushi * 5.19;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Sushi Bar")
                {
                    price = countOfSushi * 4.75;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else if (restaurant == "Asian Pub")
                {
                    price = countOfSushi * 5.50;

                    if (symbol == 'Y')
                    {
                        price = Math.Ceiling(price * 1.20);
                    }

                    Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
                }
                else
                {
                    Console.WriteLine($"{restaurant} is invalid restaurant!");
                }
            }
        }
    }
}
