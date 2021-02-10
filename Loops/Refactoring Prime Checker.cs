using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                string check = isPrime.ToString().ToLower();

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        check = isPrime.ToString().ToLower();
                        break;
                    }
                }
                Con
                sole.WriteLine("{0} -> {1}", i, check);
            }
        }
    }   
}
