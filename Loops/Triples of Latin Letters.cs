using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + j);
                        char third = (char)('a' + k);
                        
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
