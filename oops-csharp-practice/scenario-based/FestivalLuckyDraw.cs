using System;

class FestivalLuckyDraw
{
    static void Main()
    {
        Console.WriteLine("Enter number of visitors:");
        int visitors = int.Parse(Console.ReadLine());

        for (int i = 1; i <= visitors; i++)
        {
            Console.WriteLine("\nVisitor " + i + " - Enter your lucky number:");
            
            int number;
            bool isValid = int.TryParse(Console.ReadLine(), out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input! Try next visitor.");
                continue;
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("🎁 Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}
