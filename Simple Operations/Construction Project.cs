using System;

namespace ConstructionProject
{
    class Program
    {
        static void Main()
        {
            string architect = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            
            int hours = 3 * projects;
            
            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", architect, hours, projects);
        }
    }
}
