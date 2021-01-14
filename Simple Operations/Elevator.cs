using System;

namespace Elevator
{
    class Program
    {
        static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            double size = int.Parse(Console.ReadLine());
            
            double courses = Math.Ceiling(persons / size);
            
            Console.WriteLine(courses);
        }
    }
}
