using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main()
        {
            int judge = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            int juri = 0;
            double sumGrade = 0;           
            double score = 0;           
            double gradeCount = 0;

            while (command != "Finish")
            {
                while (judge > juri)
                {
                    double exam = double.Parse(Console.ReadLine());
                    
                    sumGrade += exam;
                    juri++;
                    gradeCount++;
                }

                double totalGrade = sumGrade / judge;
                
                Console.WriteLine($"{command} - {totalGrade:f2}.");
                
                score += sumGrade;
                sumGrade = 0;
                juri = 0;

                command = Console.ReadLine();
            }

            double final = score / gradeCount;
            Console.WriteLine($"Student's final assessment is {final:f2}.");
        }
    }
}
