using System;

namespace FestivalLuckyDraw
{
    // ABSTRACT CLASS (Abstraction)
    abstract class LuckyDrawc
    {
        protected int number;

        // Abstract method
        public abstract void CheckLuck(int number);
    }

    // CHILD CLASS (Inheritance)
    class DiwaliLuckyDraw : LuckyDraw
    {
        // METHOD OVERRIDING (Polymorphism)
        public override void CheckLuck(int number)
        {
            this.number = number;

            // BUSINESS LOGIC
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine(" Congratulations You won a Gift");
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Diwali Festival Lucky Draw ");
            Console.Write("Enter number of visitors: ");

            int visitors = int.Parse(Console.ReadLine());

            // OBJECT CREATION (Encapsulation + Polymorphism)
            LuckyDraw luckyDraw = new DiwaliLuckyDraw();

            for (int i = 1; i <= visitors; i++)
            {
				Console.WriteLine("visitors enter your name ");

                bool isValid =true;

                // CONTINUE FOR INVALID INPUT
                if (!isValid || number <= 0)
                {   
			
                    Console.WriteLine(" Invalid input skipping user");
                    continue;
                }
                // Calling Method
                luckyDraw.CheckLuck(number);
            }

            Console.WriteLine("Thankyou for participating in Diwali Fest");
        }
    }
}
