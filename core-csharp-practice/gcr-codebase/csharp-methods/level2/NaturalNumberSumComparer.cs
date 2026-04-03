using System;

class NaturalNumberSumComparer
{
    public static int SumUsingRecursion(int n)
    {
        if (n == 0)
            return 0;
        return n + SumUsingRecursion(n - 1);
    }

    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int recursiveSum = SumUsingRecursion(number);
        int formulaSum = SumUsingFormula(number);

        Console.WriteLine("Recursive Sum: " + recursiveSum);
        Console.WriteLine("Formula Sum: " + formulaSum);
    }
}
