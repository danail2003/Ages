using System;

namespace Coding
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char digit = number[i];
                int digitNum = int.Parse(digit.ToString());

                if (digitNum == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int j = 1; j <= digitNum; j++)
                {
                    Console.Write((char)(digitNum + 33));
                }

                Console.WriteLine();
            }
        }
    }
}
