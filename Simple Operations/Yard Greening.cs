using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main()
        {
            double yard = double.Parse(Console.ReadLine());
            
            double price = yard * 7.61;
            double discount = 0.18 * price;
            double end = price - discount;
            
            Console.Write("The final price is: ");
            Console.WriteLine($"{end:f2} lv.");
            Console.Write("The discount is: ");
            Console.WriteLine($"{discount:f2} lv.");
        }
    }
}
