using System;

// Class to find youngest and tallest friend
class FriendComparison
{
    static void Main(string[] args)
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height: ");
        double amarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height: ");
        double akbarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height: ");
        double anthonyHeight = double.Parse(Console.ReadLine());

        // Youngest
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        Console.WriteLine($"Youngest age is {youngestAge}");

        // Tallest
        double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        Console.WriteLine($"Tallest height is {tallestHeight}");
    }
}
