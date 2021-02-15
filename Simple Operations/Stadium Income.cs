using System;

namespace Stadium_Income
{
    class Program
    {
        static void Main()
        {
            int sectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double priceOfTicket = double.Parse(Console.ReadLine());

            double income = capacity * priceOfTicket;
            double incomeForSector = income / sectors;
            double moneyForCharity = (income - (incomeForSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {income:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
