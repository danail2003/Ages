using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());
            
            int count = 0;

            for (char i = firstSymbol; i <= secondSymbol; i++)
            {
                for (char j = firstSymbol; j <= secondSymbol; j++)
                {
                    for (char k = firstSymbol; k <= secondSymbol; k++)
                    {
                        if (i == thirdSymbol || j == thirdSymbol || k == thirdSymbol)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
