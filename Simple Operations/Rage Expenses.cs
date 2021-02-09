using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            
            double thrashedHeadset = Math.Floor(lostGames / 2.0);
            double thrashedMouse = Math.Floor(lostGames / 3.0);
            double thrashedKeyboard = Math.Floor(lostGames / 6.0);
            double thrashedDisplay = Math.Floor(lostGames / 12.0);

            double total = (headsetPrice * thrashedHeadset) + (mousePrice * thrashedMouse) + (keyboardPrice * thrashedKeyboard) + (displayPrice * thrashedDisplay);
            
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
