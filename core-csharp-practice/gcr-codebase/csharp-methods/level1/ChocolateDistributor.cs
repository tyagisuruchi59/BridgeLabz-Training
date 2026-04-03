using System;

class ChocolateDistributor
{
    public static int[] FindRemainderAndQuotient(int chocolates, int children)
    {
        int eachChildGets = chocolates / children;
        int remaining = chocolates % children;
        return new int[] { eachChildGets, remaining };
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(chocolates, children);

        Console.WriteLine("Each child gets: " + result[0]);
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }
}
