using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            double vacation = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int spendCounter = 0;
            int saveCounter = 0;           

            while (budget < vacation && spendCounter < 5)
            {
                string command = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                saveCounter++;

                if (command == "spend")
                {
                    spendCounter++;
                    budget -= sum;

                    if (budget < 0)
                    {
                        budget = 0;
                    }

                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(saveCounter);
                        break;
                    }
                }

                if (command == "save")
                {
                    spendCounter = 0;
                    budget += sum;

                    if (budget >= vacation)
                    {
                        Console.WriteLine($"You saved the money for {saveCounter} days.");
                        break;
                    }
                }
            }
        }
    }
}
