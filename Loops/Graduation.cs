using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main()
        {
            int badGrades = int.Parse(Console.ReadLine());
            string nameOfExercise = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());

            int counter = 0;
            double averageGrade = 0.0;
            int enough = 0;

            while (nameOfExercise != "Enough")
            {
                string lastProblem = nameOfExercise;
                counter++;

                nameOfExercise = Console.ReadLine();

                averageGrade +=  grade;
                double total = averageGrade / counter;

                if (grade <= 4)
                {
                    enough++;
                }

                if (enough == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    break;
                }

                if (nameOfExercise == "Enough")
                {
                    Console.WriteLine($"Average score: {total:f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                grade = int.Parse(Console.ReadLine());
            }
        }
    }
}
