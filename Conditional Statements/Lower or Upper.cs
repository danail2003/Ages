using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol >= 65 && symbol <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
