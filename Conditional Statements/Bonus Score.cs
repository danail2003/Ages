using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            double bonusScore = 0.0;

            if (number <= 100)
            {
                bonusScore = 5;         
            }
            else if (number <= 1000)
            {
                bonusScore = number * 0.20;
            }
            else
            {
                bonusScore = number * 0.10;
            }
            if (number % 2 == 0)
            {
                bonusScore += 1;
            }
            else if(number % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(number + bonusScore);
        }
    }
}
