using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            int odd = 0;
            int sum = 0;

            for (int i = 0; odd <number ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    
                    odd++;
                    sum += i;
                }
            }
            
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
