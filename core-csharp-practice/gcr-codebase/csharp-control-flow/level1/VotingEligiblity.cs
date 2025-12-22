using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        // Input age
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        // Check voting eligibility
        if (age >= 18)
        {
            Console.WriteLine($"The person's age is {age} and can vote.");
        }
        else
        {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}
