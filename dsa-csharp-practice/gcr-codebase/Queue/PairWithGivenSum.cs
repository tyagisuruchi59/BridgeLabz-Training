using System;
using System.Collections.Generic;

namespace DSA_HashMap
{
    class PairWithGivenSum
    {
        public static bool HasPair(int[] arr, int target)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in arr)
            {
                int complement = target - num;

                if (set.Contains(complement))
                {
                    Console.WriteLine($"Pair found: ({num}, {complement})");
                    return true;
                }

                set.Add(num);
            }

            Console.WriteLine("No pair found");
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            PairWithGivenSum.HasPair(arr, target);

            Console.ReadLine();
        }
    }
}
