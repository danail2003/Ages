using System;

namespace Histogram
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            
            double sumTwoHundred = 0;
            double sumThreeHundred = 0;
            double sumFiveHundred = 0;
            double sumSevenHundred = 0;
            double sumEightHundred = 0;           

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    sumTwoHundred += 1;                   
                }
                else if(number <= 399)
                {
                    sumThreeHundred += 1;                    
                }
                else if(number <= 599)
                {
                    sumFiveHundred += 1;                   
                }
                else if(number <= 799)
                {
                    sumSevenHundred += 1;                   
                }
                else if(number >= 800)
                {
                    sumEightHundred += 1;                    
                }
            }

            double percent1 = sumTwoHundred / numbers * 100;
            double percent2 = sumThreeHundred / numbers * 100;
            double percent3 = sumFiveHundred / numbers * 100;
            double percent4 = sumSevenHundred / numbers * 100;
            double percent5 = sumEightHundred / numbers * 100;


            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");
        }
    }
}
