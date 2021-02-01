using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            int currentNum = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write($"{currentNum} ");
                    currentNum++;

                    if (currentNum > number)
                    {
                        isBigger = true;
                        break;
                    }
                }

                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
