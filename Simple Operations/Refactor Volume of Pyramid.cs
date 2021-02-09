using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            double volume = 1 / 3.0 * length * width * height;
            
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");      
        }
    }
}
