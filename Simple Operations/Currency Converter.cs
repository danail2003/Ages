using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            
            double currency = usd * 1.79549;
            
            Console.WriteLine(Math.Round(currency, 2));
        }
    }
}
