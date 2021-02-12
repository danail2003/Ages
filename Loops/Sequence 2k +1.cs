using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= number)
            {
                Console.WriteLine(counter);

                counter *= 2 + 1;            
            }
        }
    }
}
