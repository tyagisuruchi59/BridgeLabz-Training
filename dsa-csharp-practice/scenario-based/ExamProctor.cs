using System;
using System.Collections.Generic;

class ExamProctor
{
    Stack<int> navigationStack = new Stack<int>();
    Dictionary<int, string> answers = new Dictionary<int, string>();
    Dictionary<int, string> correctAnswers = new Dictionary<int, string>();

    public ExamProctor()
    {
        correctAnswers.Add(1, "A");
        correctAnswers.Add(2, "B");
        correctAnswers.Add(3, "C");
    }

    // Track question navigation
    public void VisitQuestion(int questionId)
    {
        navigationStack.Push(questionId);
        Console.WriteLine("Visited Question: " + questionId);
    }

    // Store answer
    public void SubmitAnswer(int questionId, string answer)
    {
        answers[questionId] = answer;
    }

    // Calculate score
    public int CalculateScore()
    {
        int score = 0;

        foreach (var item in answers)
        {
            if (correctAnswers.ContainsKey(item.Key) &&
                correctAnswers[item.Key] == item.Value)
            {
                score++;
            }
        }
        return score;
    }

    static void Main()
    {
        ExamProctor exam = new ExamProctor();

        exam.VisitQuestion(1);
        exam.SubmitAnswer(1, "A");

        exam.VisitQuestion(2);
        exam.SubmitAnswer(2, "C");

        exam.VisitQuestion(3);
        exam.SubmitAnswer(3, "C");

        Console.WriteLine("Final Score: " + exam.CalculateScore());
    }
}
