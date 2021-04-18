using System;

namespace Energy_Booster
{
    class Program
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            double countOfSets = double.Parse(Console.ReadLine());

            double sum = 0;

            if (size == "big")
            {
                if (fruit == "Watermelon")
                {
                    sum += countOfSets * 5 * 28.70;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
                else if (fruit == "Mango")
                {
                    sum += countOfSets * 5 * 19.60;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
                else if (fruit == "Pineapple")
                {
                    sum += countOfSets * 5 * 24.80;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
                else if (fruit == "Raspberry")
                {
                    sum += countOfSets * 5 * 15.20;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
            }
            else if (size == "small")
            {
                if (fruit == "Watermelon")
                {
                    sum += countOfSets * 2 * 56;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
                else if (fruit == "Mango")
                {
                    sum += countOfSets * 2 * 36.66;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
                else if (fruit == "Pineapple")
                {
                    sum += countOfSets * 2 * 42.10;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
                else if (fruit == "Raspberry")
                {
                    sum += countOfSets * 2 * 20;

                    if (sum > 1000)
                    {
                        sum *= 0.5;
                    }
                    else if (sum >= 400 && sum <= 1000)
                    {
                        sum -= sum * 0.15;
                    }
                }
            }

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
