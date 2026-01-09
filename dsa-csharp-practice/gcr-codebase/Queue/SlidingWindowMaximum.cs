using System;
using System.Collections.Generic;

namespace DSA_SlidingWindow
{
    class SlidingWindowMaximum
    {
        public static void PrintMaxInWindows(int[] arr, int k)
        {
            if (arr.Length == 0 || k <= 0)
                return;

            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                // Remove indices out of current window
                if (deque.Count > 0 && deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }

                // Remove smaller elements from the back
                while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i])
                {
                    deque.RemoveLast();
                }

                // Add current index
                deque.AddLast(i);

                // Print max for current window
                if (i >= k - 1)
                {
                    Console.Write(arr[deque.First.Value] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            Console.WriteLine("Sliding Window Maximums:");
            SlidingWindowMaximum.PrintMaxInWindows(arr, k);

            Console.ReadLine();
        }
    }
}
