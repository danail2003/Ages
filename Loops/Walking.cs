using System;

namespace Walking
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            
            int goal = 0;
            
            while (command != "Going home")
            {
                goal += int.Parse(command);

                if (goal >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Going home")
            {
                int end = int.Parse(Console.ReadLine());

                goal += end;
                int stop = 10000 - goal;

                if (goal >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{stop} more steps to reach goal.");
                }
            }
        }
    }
}
