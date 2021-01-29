using System;

namespace Min_Number
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            int counter = 0;
            int minNumber = int.MaxValue;

            while (counter < count)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number < minNumber)
                {
                    minNumber = number;
                }

                counter++;
            }

            Console.WriteLine(minNumber);
        }
    }
}
