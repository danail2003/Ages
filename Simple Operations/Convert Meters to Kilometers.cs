using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main()
        {
            double meters = double.Parse(Console.ReadLine());
            
            double kilometers = meters / 1000;
            
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
