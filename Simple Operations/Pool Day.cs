using System;

namespace Pool_Day
{
    class Program
    {
        static void Main()
        {
            int humans = int.Parse(Console.ReadLine());
            double inputTax = double.Parse(Console.ReadLine());
            double priceForChair = double.Parse(Console.ReadLine());
            double priceForUmbrella = double.Parse(Console.ReadLine());

            double input = humans * inputTax;
            double percentChairs = Math.Ceiling(humans * 0.75);
            double priceChairs = percentChairs * priceForChair;
            double percentUmbrellas = Math.Ceiling(humans * 0.5);
            double priceUmbrellas = percentUmbrellas * priceForUmbrella;
            double total = input + priceChairs + priceUmbrellas;
            
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
