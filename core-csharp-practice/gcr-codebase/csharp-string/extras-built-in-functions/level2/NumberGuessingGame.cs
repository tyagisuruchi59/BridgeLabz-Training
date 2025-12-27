using System;

class NumberGuessingGame
{
    static void Main()
    {
        PlayGame();
    }

    static void PlayGame()
    {
        int low = 1, high = 100;
        string feedback;

        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Enter H (high), L (low), or C (correct)");

        while (true)
        {
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guesses: " + guess);
            feedback = GetFeedback();

            if (feedback == "C")
                break;
            else if (feedback == "H")
                high = guess - 1;
            else if (feedback == "L")
                low = guess + 1;
        }
        Console.WriteLine("Computer guessed correctly!");
    }

    static int GenerateGuess(int low, int high)
    {
        return (low + high) / 2;
    }

    static string GetFeedback()
    {
        return Console.ReadLine().ToUpper();
    }
}
