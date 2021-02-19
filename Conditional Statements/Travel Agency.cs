using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main()
        {
            string town = Console.ReadLine();
            string equipment = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price;
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (town == "Bansko" || town == "Borovets")
            {
                if (equipment == "withEquipment")
                {
                    if (days > 7)
                    {
                        price = (days - 1) * 100;
                    }
                    else
                    {
                        price = days * 100;
                    }
                    
                    if (vip == "yes")
                    {
                        price *= 0.90;
                    }

                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
                else if (equipment == "noEquipment")
                {
                    if (days > 7)
                    {
                        price = (days - 1) * 80;
                    }
                    else
                    {
                        price = days * 80;
                    }
                    
                    if (vip == "yes")
                    {
                        price *= 0.95;
                        
                    }
                    
                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (equipment == "noBreakfast")
                {
                    if (days > 7)
                    {
                        price = (days - 1) * 100;
                    }
                    else
                    {
                        price = days * 100;
                    }
                    
                    if (vip == "yes")
                    {
                        price *= 0.93;
                    }
                    
                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
                else if (equipment == "withBreakfast")
                {
                    if (days > 7)
                    {
                        price = (days - 1) * 130;
                    }
                    else
                    {
                        price = days * 130;
                    }
                    
                    if (vip == "yes")
                    {
                        price *= 0.88;
                    }
                    
                    Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }           
        }
    }
}
