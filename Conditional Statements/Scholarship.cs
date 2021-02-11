using System;

namespace Scholarship
{
    class Program
    {
        static void Main(s)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minSalary * 0.35);
            double scholarshipForSuccess = Math.Floor(averageSuccess * 25);

            if (income < minSalary && averageSuccess > 4.50 && socialScholarship > scholarshipForSuccess)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (averageSuccess >= 5.50 && scholarshipForSuccess >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForSuccess} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }        
    }
}
