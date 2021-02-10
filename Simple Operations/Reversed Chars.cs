using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            Console.Write($"{thirdSymbol} {secondSymbol} {firstSymbol}");
        }
    }
}
