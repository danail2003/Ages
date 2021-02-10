using System;

namespace Reverse_String
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string reverse = "";

            for (int i = text.Length-1; i >= 0; i--)
            {
                char digit = text[i];
                reverse += digit;
            }

            Console.WriteLine(reverse);
        }
    }
}
