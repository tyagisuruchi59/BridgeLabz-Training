using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        int[] age = new int[10];

        for (int i = 0; i < age.Length; i++)
        {
            age[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < age.Length; i++)
        {
            if (age[i] >= 18)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}   // ← THIS closing brace was missing
