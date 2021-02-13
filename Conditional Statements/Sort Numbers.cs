using System;

namespace Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firsNumber > secondNumber && firsNumber > thirdNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine(firsNumber);
                Console.WriteLine(secondNumber);
                Console.WriteLine(thirdNumber);
            }
            else if (firsNumber > secondNumber && firsNumber > thirdNumber && thirdNumber >= secondNumber)
            {
                Console.WriteLine(firsNumber);
                Console.WriteLine(thirdNumber);
                Console.WriteLine(secondNumber);
            }
            else if (secondNumber > firsNumber && secondNumber > thirdNumber && firsNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(firsNumber);
                Console.WriteLine(thirdNumber);
            }
            else if (secondNumber > firsNumber && secondNumber > thirdNumber && thirdNumber >= firsNumber)
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firsNumber);
            }
            else if (thirdNumber > firsNumber && thirdNumber > secondNumber && firsNumber >= secondNumber)
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firsNumber);
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber > firsNumber && thirdNumber > secondNumber && secondNumber >= firsNumber)
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(secondNumber);
                Console.WriteLine(firsNumber);
            }
        }
    }
}
