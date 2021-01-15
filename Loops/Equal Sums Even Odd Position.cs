using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                string num = i.ToString();

                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < num.Length; j++)
                {
                    char modify = num[j];
                    int digit = int.Parse(modify.ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                    if (evenSum == oddSum)
                    {
                        Console.Write(num + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
