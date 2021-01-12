using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int charsCount = int.Parse(Console.ReadLine());
            
            string text = "";           

            for (int i = 0; i < charsCount; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int sum = symbol + key;
                char digit = (char)sum;
                text += digit;
            }

            Console.WriteLine(text);
        }
    }
}
