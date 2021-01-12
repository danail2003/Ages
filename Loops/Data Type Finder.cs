using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                bool isInteger = int.TryParse(command, out int intValue);
                bool isChar = char.TryParse(command, out char charValue);
                bool isFloat = double.TryParse(command, out double doubleValue);
                bool isBoolean = bool.TryParse(command, out bool boolValue);

                if (isBoolean)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else if (isInteger)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (isFloat)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
            }
        }
    }
}
