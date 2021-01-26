using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            
            double operation = (firstNumber + secondNumber) / thirdNumber * fourthNumber;
            
            Console.WriteLine(operation);
        }
    }
}
