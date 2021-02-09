using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main()
        {
            double rad = double.Parse(Console.ReadLine());
            
            double degree = rad * 180 / Math.PI;
            
            Console.WriteLine(Math.Round(degree));
        }
    }
}
