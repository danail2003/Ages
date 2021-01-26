using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            
            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if (number > max)
                {
                    max = number;
                }
            }

            sum -= max;

            if (max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(sum - max);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
