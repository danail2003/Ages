using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main()
        {            
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int value = 2;

                    while (number % value != 0)
                    {
                        value++;                       
                    }

                    if (value == number)
                    {
                        sumPrime += number;
                    }
                    else
                    {
                        sumNonPrime += number;
                    }
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
