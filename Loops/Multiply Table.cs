using System;

namespace Multiply_Table
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            int digit = number % 10;
            int secondDigit = number % 100;
            secondDigit /= 10;
            int thirdDigit = number % 1000;
            thirdDigit /= 100;    

            for (int i = 1; i <= digit; i++)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= thirdDigit; k++)
                    {
                        int combination = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {combination}");
                    }
                }
            }
        }
    }
}
