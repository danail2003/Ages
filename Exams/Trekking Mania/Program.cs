using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main()
        {
            int groups = int.Parse(Console.ReadLine());

            int peopleForMusala = 0;
            int peopleForMonblan = 0;
            int peopleForKilimandjaro = 0;
            int peopleForK2 = 0;
            int peopleForEvereset = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    peopleForMusala += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    peopleForMonblan += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    peopleForKilimandjaro += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    peopleForK2 += people;
                }
                else if (people > 40)
                {
                    peopleForEvereset += people;
                }
            }

            double totalPeople = peopleForMusala + peopleForMonblan + peopleForKilimandjaro + peopleForK2 + peopleForEvereset;

            double percentForMusala = peopleForMusala / totalPeople * 100;
            double percentForMonblan = peopleForMonblan / totalPeople * 100;
            double percentForKilimandjaro = peopleForKilimandjaro / totalPeople * 100;
            double percentForK2 = peopleForK2 / totalPeople * 100;
            double percentForEverest = peopleForEvereset / totalPeople * 100;

            Console.WriteLine($"{percentForMusala:f2}%");
            Console.WriteLine($"{percentForMonblan:f2}%");
            Console.WriteLine($"{percentForKilimandjaro:f2}%");
            Console.WriteLine($"{percentForK2:f2}%");
            Console.WriteLine($"{percentForEverest:f2}%");
        }
    }
}
