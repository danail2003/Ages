using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main()
        {
            int tables = int.Parse(Console.ReadLine());
            double lengthOfTables = double.Parse(Console.ReadLine());
            double widthOfTables = double.Parse(Console.ReadLine());
            
            double area = tables * (lengthOfTables + 2 * 0.30) * (widthOfTables + 2 * 0.30);
            double totalArea = tables * (lengthOfTables / 2) * (lengthOfTables / 2);
            double priceUsd = area * 7 + totalArea * 9;
            double priceBgn = priceUsd * 1.85;
            
            Console.Write($"{priceUsd:f2}");
            Console.WriteLine(" USD");
            Console.Write($"{priceBgn:f2}");
            Console.WriteLine(" BGN");
        }
    }
}
