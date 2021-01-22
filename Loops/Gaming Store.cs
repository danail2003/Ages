using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            
            double sum = 0;
            double price = 0;

            while(game != "Game Time")
            {
                if(game == "OutFall 4")
                {
                    price = 39.99;
                    if (budget < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        sum += 39.99;
                        budget -= 39.99;
                        Console.WriteLine($"Bought {game}");
                    }                 
                }
                else if(game == "CS: OG")
                {
                    price = 15.99;
                    if (budget < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        sum += 15.99;
                        budget -= 15.99;
                        Console.WriteLine($"Bought {game}");
                    }                  
                }
                else if(game == "Zplinter Zell")
                {
                    price = 19.99;
                    if (budget < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        sum += 19.99;
                        budget = -19.99;
                        Console.WriteLine($"Bought {game}");
                    }                    
                }
                else if(game == "Honored 2")
                {
                    price = 59.99;
                    if (budget < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        sum += 59.99;
                        budget -= 59.99;
                        Console.WriteLine($"Bought {game}");
                    }                   
                }
                else if(game == "RoverWatch")
                {
                    price = 29.99;
                    if (budget < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        sum += 29.99;
                        budget -= 29.99;
                        Console.WriteLine($"Bought {game}");
                    }                   
                }
                else if(game == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    if (budget < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        sum += 39.99;
                        budget -= 39.99;
                        Console.WriteLine($"Bought {game}");
                    }   
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                }

                game = Console.ReadLine();
            }

            if (budget > 0)
            {             
                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${budget:f2}");
            }          
        }
    }
}
