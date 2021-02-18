using System;

namespace Town_Info
{
    class Program
    {
        static void Main()
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int kilometers = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {kilometers} square km.");
        }
    }
}
