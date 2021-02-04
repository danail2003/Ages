using System;

namespace Old_Books
{
    class Program
    {
        static void Main()
        {
            string book = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());

            int counter = 0;
            string searchedBook = "";

            while (searchedBook != book)
            {
                searchedBook = Console.ReadLine();

                counter++;

                if (searchedBook == book)
                {
                    Console.WriteLine($"You checked {counter - 1} books and found it.");
                    break;
                }

                if (counter >= capacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {capacity} books.");
                    break;
                }
            }
        }           
    }
}
