using System;
using System.Collections.Generic;

class ATMDispenser
{
    static void DispenseCash(int amount, int[] denominations)
    {
        Array.Sort(denominations);
        Array.Reverse(denominations); // Largest first

        Dictionary<int, int> result = new Dictionary<int, int>();
        int remaining = amount;

        foreach (int note in denominations)
        {
            if (remaining >= note)
            {
                int count = remaining / note;
                remaining %= note;
                result[note] = count;
            }
        }

        if (remaining == 0)
        {
            Console.WriteLine($"Dispensing ₹{amount}:");
            foreach (var item in result)
                Console.WriteLine($"₹{item.Key} x {item.Value}");
        }
        else
        {
            Console.WriteLine($"Exact amount ₹{amount} cannot be dispensed.");
            Console.WriteLine($"Remaining amount: ₹{remaining}");
            Console.WriteLine("Fallback combo:");
            foreach (var item in result)
                Console.WriteLine($"₹{item.Key} x {item.Value}");
        }
    }

    static void Main()
    {
        int amount = 880;

        Console.WriteLine("Scenario A: All Notes Available");
        int[] notesA = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
        DispenseCash(amount, notesA);

        Console.WriteLine("\nScenario B: ₹500 Removed");
        int[] notesB = { 1, 2, 5, 10, 20, 50, 100, 200 };
        DispenseCash(amount, notesB);

        Console.WriteLine("\nScenario C: Fallback Example");
        int[] notesC = { 2, 5 };
        DispenseCash(3, notesC);
    }
}
