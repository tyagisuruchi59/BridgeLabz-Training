using System;
using System.Collections.Generic;

namespace Systems
{
    public class BankingSystem
    {
        public static void Run()
        {
            Queue<int> withdrawals = new();
            withdrawals.Enqueue(1000);
            withdrawals.Enqueue(500);

            while (withdrawals.Count > 0)
                Console.WriteLine("Processed ₹" + withdrawals.Dequeue());
        }
    }
}