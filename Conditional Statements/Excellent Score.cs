using System;

namespace Excellent_Score
{
    class Program
    {
        static void Main()
        {
            double score = double.Parse(Console.ReadLine());

            if (score >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
