using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            int counter = 0;
            int counter2 = 0;
            double total = 0.0;

            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                
                if (grade < 4)
                {
                    counter2++;
                    if (counter2 == 2)
                    {                     
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        break;
                    } 
                }
                else
                {
                    total += grade;
                    if (counter == 11)
                    {
                        double average = total / 12;
                        Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
                    }                    
                }
                counter++;
            }            
        }
    }
}
