using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());
            
            int total = 0;
            int counter = 0;

            if (yield >= 100)
            {
                while (yield >= 100)
                {
                    int flow = yield - 26;
                    total += flow;
                    yield -= 10;
                    counter++;
                }
                
                total -= 26;
                
                Console.WriteLine(counter);
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine(counter);
                Console.WriteLine(total);
            }
            
        }
    }
}
