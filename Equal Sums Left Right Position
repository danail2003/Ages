using System;

namespace Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int number = i;
                int leftSum = 0;
                int rightSum = 0;
                int extraSum = 0;

                for (int j = 5; j >= 1; j--)
                {
                    int one = number % 10;
                    int rest = number / 10;
                    number = rest;

                    if (j > 3)
                    {
                        rightSum += one;
                    }
                    else if (j == 3)
                    {
                        extraSum += one;
                    }
                    else if (j < 3)
                    {
                        leftSum += one;
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    if (leftSum > rightSum)
                    {
                        rightSum += extraSum;
                        if (leftSum == rightSum)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    else if (leftSum < rightSum)
                    {
                        leftSum += extraSum;
                        if (leftSum == rightSum)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
        }
    }
}
