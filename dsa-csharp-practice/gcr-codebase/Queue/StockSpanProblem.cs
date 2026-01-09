using System;
using System.Collections.Generic;

namespace DSA_StockSpan
{
    class StockSpan
    {
        public static int[] CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                // Pop elements while current price is higher
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                // If stack empty, span is i + 1
                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

                // Push current index
                stack.Push(i);
            }

            return span;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

            int[] span = StockSpan.CalculateSpan(prices);

            Console.WriteLine("Stock Prices:");
            PrintArray(prices);

            Console.WriteLine("Stock Spans:");
            PrintArray(span);

            Console.ReadLine();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
