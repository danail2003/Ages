using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main()
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            int percentOfDiscount = int.Parse(Console.ReadLine());

            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double chemicalPriceForLiter = 1.20;

            double totalPrice = (pensCount * pensPrice) + (markersCount * markersPrice) + (liters * chemicalPriceForLiter);
            double neededPrice = totalPrice - (totalPrice * percentOfDiscount / 100);
            Console.WriteLine($"{neededPrice:f3}");
        }
    }
}
