using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main()
        {
            double pounds = double.Parse(Console.ReadLine());
            
            double dollars = pounds * 1.31;
            
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
