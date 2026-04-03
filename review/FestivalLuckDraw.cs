using System;

namespace FestivalLuckyDraw
{
    // ABSTRACT CLASS (Abstraction)
    abstract class LuckyDraw
    {
        

        // Abstract method
        public abstract void CheckLuck(int number);
    }

    // CHILD CLASS (Inheritance)
    class DiwaliLuckyDraw : LuckyDraw
    {
	    int number;
        // METHOD OVERRIDING (Polymorphism)
        public override void CheckLuck(int number)
        {
            this.number = number;

            //  LOGIC
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

    class FestivalLuckyDraw
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Diwali Festival Lucky Draw ");
            Console.Write("Enter number of visitors: ");

            int visitors = int.Parse(Console.ReadLine());

            // OBJECT CREATION (Encapsulation + Polymorphism)
            LuckyDraw luckyDraw = new DiwaliLuckyDraw();

            for (int i = 0; i <visitors; i++)
            {
				Console.WriteLine("visitors enter your name ");

                bool isValid = int.Parse(Console.ReadLine(),  int number);

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
