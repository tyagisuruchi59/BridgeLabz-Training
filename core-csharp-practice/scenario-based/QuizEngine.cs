using System;

// Central unit that manages quiz flow and scoring
static class QuizEngine
{
    // holds total points earned
    private static int marksCount = 0;

    // question bank
    private static string[] quizItems = {
        "Which country is known as the Land of the Rising Sun?",
        "Who is called the architect of the Indian Constitution?",
        "Which planet has the largest number of moons?",
        "What is the national flower of India?",
        "Which river flows through Egypt?",
        "Who invented the airplane?",
        "Which continent is completely covered with ice?",
        "Which gas helps in combustion?",
        "Who founded the Mughal Empire in India?",
        "How many hours are there in two days?"
    };

    // answer key
    private static string[] answerKey = {
        "Japan",
        "B.R. Ambedkar",
        "Saturn",
        "Lotus",
        "Nile",
        "Wright Brothers",
        "Antarctica",
        "Oxygen",
        "Babur",
        "48"
    };

    // shares questions with the player
    public static string[] LoadQuestions()
    {
        return quizItems;
    }

    public static void Main()
    {
        QuizPlayer player = new QuizPlayer();

        string[] playerResponses = player.GetResponses(LoadQuestions());

        // score calculation
        for (int index = 0; index < playerResponses.Length; index++)
        {
            string userInput = playerResponses[index];

            if (!string.IsNullOrWhiteSpace(userInput) &&
                userInput.Trim().Equals(answerKey[index], StringComparison.OrdinalIgnoreCase))
            {
                marksCount++;
            }
        }

        Console.WriteLine("Total Marks Scored : " + marksCount);
    }
}

// Responsible only for taking input from the player
class QuizPlayer
{
    internal string[] GetResponses(string[] prompts)
    {
        string[] capturedAnswers = new string[prompts.Length];

        Console.WriteLine(">>> Quiz Started <<<");

        for (int pos = 0; pos < prompts.Length; pos++)
        {
            Console.WriteLine(prompts[pos]);
            capturedAnswers[pos] = Console.ReadLine();
        }

        return capturedAnswers;
    }
}