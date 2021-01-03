using System;

namespace Best_Player
{
    class Program
    {
        static void Main()
        {
            string command = "";           
            int maxGoals = int.MinValue;
            int goals = 0;
            string name = "";
            string bestPlayer = "";

            while (command != "END")
            {
                command = Console.ReadLine();
               
                if(command != "END")
                {
                    name = command;
                    goals = int.Parse(Console.ReadLine());
                }
                
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = name;
                }

                if (goals >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            
            if (goals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
